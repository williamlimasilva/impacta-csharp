using ApiCatalogo.Data;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        //Dependency Injection
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        //GET: api/<ProdutosController>/primeiro
        [HttpGet("primeiro")]
        public ActionResult<Produto> GetPrimeiro()
        {
            var produto = _context.Produtos.FirstOrDefault();
            if (produto is null)
            {
                return NotFound("Nenhum produto encontrado");
            }
            return Ok(produto);
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos.IsNullOrEmpty())
            {
                return NotFound("No products found."); //HTTP 404 Not Found
            }
            else
            {
                return produtos; //HTTP 200 OK
            }
        }

        // GET api/<ProdutosController>/1
        [HttpGet("{id:int}")]
        public ActionResult<Produto> Get(int id)
        { 
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if(produto is null)
            {
                return NotFound($"Product with ID {id} not found."); //HTTP 404 Not Found
            }
            else
            {
                return produto; //HTTP 200 OK
            }
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public ActionResult<Produto> Post([FromBody] Produto produto)
        {
            if (produto.Equals(null))
            {
                return BadRequest("Product data is null."); //HTTP 400 Bad Request
            }
            else
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return CreatedAtAction(nameof(Get), new { id = produto.ProdutoId }, produto); //HTTP 201 Created
            }
        }

        // DELETE api/<ProdutosController>/1
        [HttpDelete("{id:int}")]
        public ActionResult<Produto> Delete(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto is null)
            {
                return NotFound($"Product with ID {id} not found."); //HTTP 404 Not Found
            }
            else
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return NoContent(); //HTTP 204 No Content
            }
        }

        // PUT api/<ProdutosController>/1
        [HttpPut("{id}")]
        public ActionResult<Produto> Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest($"O ID: {id} do produto: {produto} não corresponde ao ID da URL.");
            }
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);

        }
    }
}
