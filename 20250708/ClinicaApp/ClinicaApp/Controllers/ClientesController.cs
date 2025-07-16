using ClinicaApp.Data;
using ClinicaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApp.Controllers
{
    public class ClientesController : Controller
    {
        //Injeção de dependencia ClientesContext Entity Framework
        private readonly ClinicaContext _context;

        public ClientesController(ClinicaContext context)
        {
            _context = context;
        }

        //GET * Quando não tiver tag sempre será [HttpGet]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,DataNascimento,Salario")] Cliente cliente)
        {
           _context.Clientes.Add(cliente);
           await _context.SaveChangesAsync();
           return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(cliente);

        }

        private bool ClienteExists(int clienteId)
        {
            return _context.Clientes.Any(c => c.ClienteId == clienteId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,Nome,DataNascimento,Salario")] Cliente cliente)
        {
            if (!ClienteExists(cliente.ClienteId))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ClienteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
