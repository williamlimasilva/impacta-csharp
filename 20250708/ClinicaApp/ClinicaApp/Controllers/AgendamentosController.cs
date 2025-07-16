using ClinicaApp.Data;
using ClinicaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApp.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly ClinicaContext _context;

        public AgendamentosController(ClinicaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                // Aqui você pode adicionar a lógica para salvar o agendamento no banco de dados
                _context.Agendamentos.Add(agendamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agendamento);
        }
    }
}
