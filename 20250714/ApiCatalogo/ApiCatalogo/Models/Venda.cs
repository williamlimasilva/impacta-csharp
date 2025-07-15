using System.Collections.ObjectModel;

namespace ApiCatalogo.Models;

public class Venda
{
    public Venda()
    {
        Produtos = new Collection<Produto>();
    }
    public int VendaId { get; set; }

    public DateTime DataVenda { get; set; }

    public decimal ValorTotal { get; set; }

    public int ProdutoId { get; set; }
    public ICollection<Produto> Produtos { get; set; }

}