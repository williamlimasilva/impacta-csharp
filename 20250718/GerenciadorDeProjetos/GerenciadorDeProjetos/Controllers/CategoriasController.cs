using GerenciadorDeProjetos.Data;
using GerenciadorDeProjetos.Models;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeProjetos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        // SAI #1
        // private readonly AppDbContext _context;

        // public CategoriasController(AppDbContext context)
        // {
        //     _context = context;
        // }

        // ENTRA #1
        // SAI #2
        //private readonly ICategoriaRepository _categoriaRepository;

        //// Agora o controller depende da ABSTRAÇÃO (interface) e não da implementação.
        //public CategoriasController(ICategoriaRepository categoriaRepository)
        //{
        //    _categoriaRepository = categoriaRepository;
        //}

        // ENTRA #2
        private readonly IUnitOfWork _uow;

        public CategoriasController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // POST: api/Categorias
        [HttpPost]
        public async Task<IActionResult> CriarCategoria([FromBody] Categoria categoria)
        {
            //await _categoriaRepository.AddAsync(categoria);
            //await _categoriaRepository.SaveChangesAsync();
            await _uow.CategoriaRepository.AddAsync(categoria);
            await _uow.CommitAsync();
            return CreatedAtAction(nameof(BuscarCategoriaPorId), new { id = categoria.Id }, categoria);
        }

        // Endpoint para buscar uma categoria específica pelo seu ID, incluindo seus produtos.
        // GET /api/categorias/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarCategoriaPorId(int id)
        {
            // SAI
            // var categoria = await _context.Categorias
            //                               .Include(c => c.Produtos)
            //                               .FirstOrDefaultAsync(c => c.Id == id);

            // ENTRA
            //var categoria = await _categoriaRepository.GetByIdWithProductsAsync(id);
            var categoria = await _uow.CategoriaRepository.GetByIdWithProductsAsync(id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            return Ok(categoria);

        }

    }
}
