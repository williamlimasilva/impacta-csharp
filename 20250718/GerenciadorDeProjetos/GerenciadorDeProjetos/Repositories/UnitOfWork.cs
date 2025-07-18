using GerenciadorDeProjetos.Data;
using GerenciadorDeProjetos.Repositories.Interfaces;

namespace GerenciadorDeProjetos.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        // Declarando os repositórios como propriedades
        public ICategoriaRepository CategoriaRepository { get; private set; }
        public IProdutoRepository ProdutoRepository { get; private set; }
        
        //  FORMA NOVA
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            // Inicializa o repositórios com contexto
            CategoriaRepository = new CategoriaRepository(_context);
            ProdutoRepository = new ProdutoRepository(_context);
        }

        // FORMA ANTIGA
        //public UnitOfWork(AppDbContext context, ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository) : this(context)
        //{
        //    this.categoriaRepository = categoriaRepository;
        //    this.produtoRepository = produtoRepository;
        //}        

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
