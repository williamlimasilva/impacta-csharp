namespace MiniCatalogo.Core.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(string name, decimal price, string type);
    }
}
