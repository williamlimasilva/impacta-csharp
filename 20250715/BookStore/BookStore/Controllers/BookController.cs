using BookStore.Models;
using BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IRepository _repository;

        public BookController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _repository.GetAllAsync<Book>();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _repository.GetByIdAsync<Book>(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            await _repository.AddAsync(book);
            await _repository.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.BookId }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.BookId)
                return BadRequest();

            await _repository.UpdateAsync(book);
            await _repository.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _repository.DeleteAsync<Book>(id);
            await _repository.SaveChangesAsync();
            return NoContent();
        }
    }
}
