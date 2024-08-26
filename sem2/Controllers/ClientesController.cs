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
    }
}
