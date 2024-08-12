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
    }
}
