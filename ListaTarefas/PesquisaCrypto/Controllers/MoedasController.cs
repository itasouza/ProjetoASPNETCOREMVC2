using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Data;
using PesquisaCrypto.Models;

namespace PesquisaCrypto.Controllers
{
    public class MoedasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoedasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Moedas
        public async Task<IActionResult> Index()
        {
            return View(await _context.MOEDA.ToListAsync());
        }


        public JsonResult DadosGrafico()
        {
            return Json(_context.MOEDA.Select(x => new { x.Nome, x.Quantidade}));
        }

        public async Task<IActionResult> EscolhaDeMoedas(List<Moeda> moedas)
        {
            foreach(var item in moedas)
            {
                if(item.CheckBoxMarcado == true)
                {
                    Moeda moeda = await _context.MOEDA.FirstAsync(x => x.MoedaId == item.MoedaId);
                    moeda.Quantidade = moeda.Quantidade + 1;
                    _context.Update(moeda);
                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Moedas/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoedaId,Nome,Quantidade")] Moeda moeda)
        {
            if (ModelState.IsValid)
            {
                moeda.Quantidade = 0;
                _context.Add(moeda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moeda);
        }


    }
}
