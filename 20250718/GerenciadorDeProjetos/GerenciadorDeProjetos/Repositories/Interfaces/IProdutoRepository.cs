using GerenciadorDeProjetos.Models;

namespace GerenciadorDeProjetos.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        // Define um método para buscar um produto
        Task AddAsync(Produto produto);
        Task<IEnumerable<Produto>> GetAllAsync();
    }
}
