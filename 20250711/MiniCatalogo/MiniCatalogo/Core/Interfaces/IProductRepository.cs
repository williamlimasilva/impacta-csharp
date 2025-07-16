
namespace MiniCatalogo.Core.Interfaces
{
    public interface IProductRepository //Declaração Abstrata
    {
        Task AddAsync(Product product);        
    }
}
