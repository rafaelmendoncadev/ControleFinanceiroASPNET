using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, string password)
        {
            if (userName == "admin" && password == "senha123")
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Usuário ou senha inválidos.";
            return View();
        }
    }
}
