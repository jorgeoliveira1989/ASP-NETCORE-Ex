using Microsoft.AspNetCore.Mvc;
using ASP21.Models;

namespace ASP21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //apresenta o menu inicial
            return View();
        }

        public IActionResult lista_clientes()
        {
            //APresenta os clientes Registados na Aplicação
            return View(Dados.todos_os_clientes());
        }
    }
}
