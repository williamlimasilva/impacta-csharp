using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Venda>> Get()
        {
            var vendas = new List<Venda>
            {
                new Venda
                {
                    VendaId = 1,
                    DataVenda = DateTime.Now,
                    ValorTotal = 100.00m,
                    Produtos = new List<Produto>
                    {
                        new Produto { ProdutoId = 1, Nome = "Produto A", Preco = 50.00m },
                        new Produto { ProdutoId = 2, Nome = "Produto B", Preco = 50.00m }
                    }
                }
            };
            return Ok(vendas);
        }        

    }
}
