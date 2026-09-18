using Microsoft.AspNetCore.Mvc;
using AppMvc.Data;
using AppMvc.Models;
namespace AppMvc.Controllers {
    public class TarefaController : Controller {
        private readonly AppDbContext _context;

        public TarefaController(AppDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            var tarefas = _context.Banco.ToList();

            return View(tarefas);
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa) {
            _context.Banco.Add(tarefa);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create() {
            return View();
        }
    }
}

