using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sem2.Data;
using sem2.Models;
using System.ComponentModel.DataAnnotations;

namespace sem2.Controllers
{
    public class ClienteController : Controller
    {
        private readonly LocacoesContext _context;

        public ClienteController(LocacoesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.OrderBy(cli => cli.Nome).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult Create(Cliente cliente)
    //    {
    //        cliente.ID = Clientes.Select(x => x.ID).Max() + 1;
    //        Clientes.Add(cliente);
    //        return RedirectToAction("Index");
    //    }
    //    public IActionResult Edit( int id)
    //    {
    //        return View(Clientes.Where(cli => cli.ID == id).First());
    //    }
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult Edit(Cliente cliente)
    //    {
    //        var clienteOld = Clientes.Where(cli => cliente.ID == cliente.ID).First(); Clientes.Remove(clienteOld);Clientes.Add(cliente);
    //        return RedirectToAction("Index");
    //    }
    //    public IActionResult Details( int id)
    //    {
    //        return View(Clientes.Where(cli=>cli.ID==id).First());
    //    }
    //    public IActionResult Delete(int id)
    //    {
    //        return View(Clientes.Where(cli=>cli.ID == id).First());
    //    }
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult DeleteConfirmed(int id)
    //    {
    //        var cliente = Clientes.Where(cliente => cliente.ID == id).First();
    //        Clientes.Remove(cliente);
    //        return RedirectToAction("Index");
    //    }
    }
}
