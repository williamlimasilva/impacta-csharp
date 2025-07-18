// Models/Categoria.cs
namespace GerenciadorDeProjetos.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }

    // Propriedade de navegação: Uma categoria pode ter vários produtos.
    // É ESSENCIAL para o EF Core entender a relação.
    // ATENÇÃO: Essa linha será a causa do nosso futuro erro de serialização.
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

    public int QuantidadeDeProdutos { get; set; }
}
