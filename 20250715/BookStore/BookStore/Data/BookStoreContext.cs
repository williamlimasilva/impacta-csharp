using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        private DbSet<Author> author = default!;

        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get => author; set => author = value; }
        public DbSet<Book> Book { get; set; } = default!;
    }
}
