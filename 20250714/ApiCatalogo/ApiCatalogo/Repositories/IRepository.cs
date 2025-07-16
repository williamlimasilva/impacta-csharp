using ApiCatalogo.Models;

namespace ApiCatalogo.Repositories
{
    public interface IRepository
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;

        Task<T?> GetByIdAsync<T>(int id) where T : class;
        
        Task<T> AddAsync<T>(T entity) where T : class;
        
        Task<T> UpdateAsync<T>(T entity) where T : class;
        
        Task<bool> DeleteAsync<T>(int id) where T : class;
        
        Task<bool> SaveChangesAsync();

        Task<Categoria?> GetCategoriaComProdutosAsync(int id);

    }

    /* Simplificado:
     * public interface IRepository<TEntity> where TEntity : class 
     * { 
     * Task<IEnumerable<TEntity>> GetAllAsync(); 
     * Task<TEntity> GetAsync(int id); 
     * Task<TEntity> AddAsync(TEntity entity); 
     * Task<TEntity> UpdateAsync(TEntity entity); 
     * Task<TEntity> DeleteAsync(TEntity entity); 
     * }
     */
}
