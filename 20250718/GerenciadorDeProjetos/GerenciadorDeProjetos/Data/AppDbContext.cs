using GerenciadorDeProjetos.Models;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorDeProjetos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais para o modelo, se necessário
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");
        }
        // Mapeia o modelo Categoria para uma tabela "Categorias" no banco
        public DbSet<Categoria> Categorias { get; set; }

        // Mapeia o modelo Produto para uma tabela "Produtos" no banco
        public DbSet<Produto> Produtos { get; set; }
    }
}


