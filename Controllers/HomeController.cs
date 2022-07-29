using Microsoft.AspNetCore.Mvc;
using MinhaAplicacaoVS.Models;
using System.Diagnostics;

namespace MinhaAplicacaoVS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UsuarioAdm usuarioAdm = new UsuarioAdm();
            usuarioAdm.NomeUsuarioAdm = "Daniel Falcão";
            usuarioAdm.EmailUsuarioAdm = "danieleducadorg@gmail.com";

            return View(usuarioAdm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}