using GerenciadorDeProjetos.Models;

namespace GerenciadorDeProjetos.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriaRepository CategoriaRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        // Centralizar as operações no banco de dados
        Task<int> CommitAsync();
    }
}
