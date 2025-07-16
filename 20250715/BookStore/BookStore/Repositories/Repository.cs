using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repositories
{
    public class Repository : IRepository
    {
        private readonly BookStoreContext _context;

        public Repository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync<T>(int id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public Task UpdateAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync<T>(int id) where T : class
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
                _context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
