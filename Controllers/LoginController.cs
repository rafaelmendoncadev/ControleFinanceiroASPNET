using Microsoft.AspNetCore.Mvc;
using ControleFinanceiro.Data;
using ControleFinanceiro.Models;
using System.Linq;

namespace ControleFinanceiro.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string nome, string senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Nome == nome && u.Senha == senha);

            if (usuario != null)
            {
                // Usuário autenticado com sucesso
                // Aqui você pode salvar informações na sessão, redirecionar, etc.
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Erro = "Usuário ou senha inválidos.";
                return View();
            }
        }

        public IActionResult Logout()
        {
            // Limpe a sessão ou autenticação aqui, se necessário
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
