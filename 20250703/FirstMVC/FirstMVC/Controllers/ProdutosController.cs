using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clientes() {
            return View();
        }
    }
}
