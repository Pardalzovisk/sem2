using Microsoft.AspNetCore.Mvc;
using sem2.Models;

namespace sem2.Controllers
{
    public class ClienteController : Controller
    {
        public static IList<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                ID = 1,
                Nome = "Rebeca",
                Email = "reb@a.com",
                Telefone = "12345678",
                Cidade = "VR"

            },
            new Cliente()
            {
               ID = 2,
               Nome = "Heeheehaha",
               Email = "Hehihia@b.com",
               Telefone = "87654321",
               Cidade = "BM"
            },
        };

        public IActionResult Index()
        {
            return View(Clientes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            cliente.ID = Clientes.Select(x => x.ID).Max() + 1;
            Clientes.Add(cliente);
            return RedirectToAction("Index");
        }
        public IActionResult Edit( int id)
        {
            return View(Clientes.Where(cli => cli.ID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            var clienteOld = Clientes.Where(cli => cliente.ID == cliente.ID).First(); Clientes.Remove(clienteOld);Clientes.Add(cliente);
            return RedirectToAction("Index");
        }
        public IActionResult Details( int id)
        {
            return View(Clientes.Where(cli=>cli.ID==id).First());
        }
        public IActionResult Delete(int id)
        {
            return View(Clientes.Where(cli=>cli.ID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = Clientes.Where(cliente => cliente.ID == id).First();
            Clientes.Remove(cliente);
            return RedirectToAction("Index");
        }
    }
}
