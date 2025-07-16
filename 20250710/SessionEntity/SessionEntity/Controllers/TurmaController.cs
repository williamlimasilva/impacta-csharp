using SessionEntity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SessionEntity.Controllers
{
    public class TurmasController : Controller
    {
        private readonly SessionEntityContext _context;

        public TurmasController(SessionEntityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var turmas = await _context.Grade.ToListAsync();
            return View(turmas);
        }

        // GET: Turmas/AlunosPorTurma/1
        public async Task<IActionResult> AlunosPorTurma(int id)
        {
            var turma = await _context.Grade
                .Include(t => t.Students)
                .FirstOrDefaultAsync(t => t.GradeId == id);
            
            if (turma == null)
            {
                return NotFound();
            }
            
            return View(turma);
        }
    }
}

