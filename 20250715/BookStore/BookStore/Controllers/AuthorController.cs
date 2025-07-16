using BookStore.Models;
using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IRepository _repository;

        public AuthorController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            var authors = await _repository.GetAllAsync<Author>();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await _repository.GetByIdAsync<Author>(id);
            if (author == null)
                return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            await _repository.AddAsync(author);
            await _repository.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAuthor), new { id = author.AuthorId }, author);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            if (id != author.AuthorId)
                return BadRequest();

            await _repository.UpdateAsync(author);
            await _repository.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _repository.DeleteAsync<Author>(id);
            await _repository.SaveChangesAsync();
            return NoContent();
        }
    }
}
