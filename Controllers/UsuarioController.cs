using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ControleFinanceiro.Data;
using ControleFinanceiro.Models;

namespace ControleFinanceiro.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                ViewBag.Message = "Usuário cadastrado com sucesso!";
                return View();
            }
            return View(usuario);
        }
    }
}
