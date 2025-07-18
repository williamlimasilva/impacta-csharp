using GerenciadorDeProjetos.Data;
using GerenciadorDeProjetos.Models;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeProjetos.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Rota base: /api/produtos
    public class ProdutosController : ControllerBase
    {
        // SAI
        // private readonly AppDbContext _context;
        // public ProdutosController(AppDbContext context)
        // {
        //    _context = context;
        // }

        // ENTRA
        private readonly IUnitOfWork _uow;
        public ProdutosController(IUnitOfWork uow)
        {
            _uow = uow;
        }


        // Endpoint para criar um novo produto.
        // POST /api/produtos
        [HttpPost]
        public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
        {
            // SAI
            // var categoriaExistente = await _context.Categorias.FindAsync(produto.CategoriaId);

            // ENTRA
            var categoriaExistente = await _uow.CategoriaRepository.FindByIdAsync(produto.CategoriaId);

            if (categoriaExistente == null)
            {
                return BadRequest("A CategoriaId fornecida não existe.");
            }

            // SAI
            // await _context.Produtos.AddAsync(produto);
            // await _context.SaveChangesAsync();

            // ENTRA
            await _uow.ProdutoRepository.AddAsync(produto);
            await _uow.CommitAsync();

            return Ok(produto);
        }

    }

}