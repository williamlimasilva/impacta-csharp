using GerenciadorDeProjetos.DTOs;
using GerenciadorDeProjetos.Models;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeProjetos.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Rota base: /api/produtos
    public class ProdutosController : ControllerBase
    {


        private readonly IUnitOfWork _uow;
        public ProdutosController(IUnitOfWork uow)
        {
            _uow = uow;
        }


        // Endpoint para criar um novo produto.
        // POST /api/produtos
        [HttpPost]
        // SAI
        // public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
        // ENTRA
        public async Task<IActionResult> CriarProduto([FromBody] CriarProdutoDto produtoDto)
        {
            // SAI
            // var categoriaExistente = await _uow.CategoriaRepository.FindByIdAsync(produto.CategoriaId);
            // ENTRA
            var categoriaExistente = await _uow.CategoriaRepository.FindByIdAsync(produtoDto.CategoriaId);

            if (categoriaExistente == null)
            {
                return BadRequest("A CategoriaId fornecida não existe.");
            }

            // Mapeamento do DTO para a Entidade
            var produto = new Produto
            {
                Nome = produtoDto.Nome,
                Preco = produtoDto.Preco,
                CategoriaId = produtoDto.CategoriaId
            };

            await _uow.ProdutoRepository.AddAsync(produto);
            await _uow.CommitAsync();

            // Mapeamento da entidade criada para um DTO de resposta
            var produtoResultDto = new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco
            };

            return Ok(produtoResultDto);
        }
    }
}