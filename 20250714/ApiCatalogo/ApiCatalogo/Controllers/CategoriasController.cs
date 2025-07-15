using ApiCatalogo.Data;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Categorias
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var categorias = _context.Categorias.Select(c => c.Nome).ToList();
            if (categorias == null || !categorias.Any())
            {
                return NotFound("No categories found."); //HTTP 404 Not Found
            }
            return Ok(categorias); //HTTP 200 OK
        }

        // GET: api/Categorias/1
        [HttpGet("{id:int}")]
        public ActionResult<Categoria> Get(int id)
        { 
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound($"Category with ID {id} not found."); //HTTP 404 Not Found
            }
            return Ok(categoria); //HTTP 200 OK
        }

        // POST: api/Categorias
        [HttpPost]
        public ActionResult<Categoria> Post([FromBody] Categoria categoria)
        {
            if (categoria == null)
            {
                return BadRequest("Category data is null."); //HTTP 400 Bad Request
            }
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = categoria.CategoriaId }, categoria); //HTTP 201 Created
        }

        // PUT: api/Categorias/1
        [HttpPut("{id:int}")]
        public ActionResult<Categoria> Put(int id, [FromBody] Categoria categoria)
        {
            if (categoria == null || categoria.CategoriaId != id)
            {
                return BadRequest("Category data is null or ID mismatch."); //HTTP 400 Bad Request
            }
            var existingCategoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            if (existingCategoria == null)
            {
                return NotFound($"Category with ID {id} not found."); //HTTP 404 Not Found
            }
            existingCategoria.Nome = categoria.Nome;
            existingCategoria.ImagemUrl = categoria.ImagemUrl;
            _context.Categorias.Update(existingCategoria);
            _context.SaveChanges();
            return Ok(existingCategoria); //HTTP 200 OK
        }

        // DELETE: api/Categorias/1
        [HttpDelete("{id:int}")]
        public ActionResult<Categoria> Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound($"Category with ID {id} not found."); //HTTP 404 Not Found
            }
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
            return NoContent(); //HTTP 204 No Content
        }
    }
}
