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

        public IActionResult adicionar_clientes()
        {
            //Adicionar um novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult adicionar_cliente(Cliente cliente)
        {
            //Guardar os dados do novo cliente
            Dados.adicionar_cliente(cliente);

            return RedirectToAction("adicionar_clientes");

        }

        public IActionResult editar_cliente(int id)
        {
            //editar os dados dos cliente que foi escolhido

            return View(Dados.dados_cliente(id));
        }

        [HttpPost]
        public IActionResult editar_cliente(Cliente c)
        {
            Dados.editar_cliente(c);
            return RedirectToAction("lista_clientes");
        }

        public IActionResult eliminar_cliente(int id)
        {
            //Eliminar o cliente escolhido
            Dados.eliminar_cliente(id);
            return RedirectToAction("lista_clientes");
        }
    }
}
