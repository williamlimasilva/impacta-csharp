using GerenciadorDeProjetos.DTOs;
using GerenciadorDeProjetos.Models;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        // POST /api/categorias
        [HttpPost]
        // SAI
        // public async Task<IActionResult> CriarCategoria([FromBody] Categoria categoria)
        // ENTRA
        public async Task<IActionResult> CriarCategoria([FromBody] CriarCategoriaDto categoriaDto)
        {
            // Mapeamento do DTO para a Entidade
            var categoria = new Categoria
            {
                Nome = categoriaDto.Nome
            };

            await _uow.CategoriaRepository.AddAsync(categoria);
            await _uow.CommitAsync();

            // Mapeamento da Entidade para um DTO de retorno (opcional, mas boa prática)
            var categoriaResultDto = new CategoriaComProdutosDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome
            };


            return CreatedAtAction(nameof(BuscarCategoriaPorId), new { id = categoria.Id }, categoriaResultDto);
        }

        // Endpoint para buscar uma categoria específica pelo seu ID, incluindo seus produtos.
        // GET /api/categorias/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarCategoriaPorId(int id)
        {
            var categoria = await _uow.CategoriaRepository.GetByIdWithProductsAsync(id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            // SAI
            // return Ok(categoria);

            // ENTRA
            // Mapeamento manual da entidade Categoria para o nosso DTO.
            var categoriaDto = new CategoriaComProdutosDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                // Usamos Linq para transformar cada Produto da lista em um ProdutoDto.
                Produtos = categoria.Produtos.Select(p => new ProdutoDto
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Preco = p.Preco
                }).ToList()
            };

            // Retornamos o DTO, que é um objeto limpo e sem referências circulares.
            return Ok(categoriaDto);
        }
    }
}
