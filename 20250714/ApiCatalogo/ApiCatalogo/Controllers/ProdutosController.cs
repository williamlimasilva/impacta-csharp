using ApiCatalogo.Models;
using ApiCatalogo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IRepository _repository;

        public ProdutosController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            var produtos = await _repository.GetAllAsync<Produto>();
            return Ok(produtos);
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id:int}", Name = "ObterProduto")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _repository.GetByIdAsync<Produto>(id);
            if (produto is null)
            {
                return NotFound($"Product with ID {id} not found."); // HTTP 404 Not Found
            }
            return Ok(produto); // HTTP 200 OK
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public async Task<ActionResult<Produto>> Post([FromBody] Produto produto)
        {
            if (produto is null)
            {
                return BadRequest("Product data is null."); // HTTP 400 Bad Request
            }

            await _repository.AddAsync(produto);
            await _repository.SaveChangesAsync();

            return CreatedAtRoute("ObterProduto", new { id = produto.ProdutoId }, produto); // HTTP 201 Created
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Produto>> Put(int id, [FromBody] Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest($"O ID: {id} do produto não corresponde ao ID da URL.");
            }

            await _repository.UpdateAsync(produto);
            await _repository.SaveChangesAsync();

            return Ok(produto); // HTTP 200 OK
        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _repository.DeleteAsync<Produto>(id);
            if (!deleted)
            {
                return NotFound($"Product with ID {id} not found."); // HTTP 404 Not Found
            }

            await _repository.SaveChangesAsync();
            return NoContent(); // HTTP 204 No Content
        }
    }
}
