using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeDespesas.Data;
using GerenciamentoDeDespesas.Dto;
using GerenciamentoDeDespesas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeDespesas.Controllers
{
    public class SalarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Salario
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Salarios.Include(s => s.Mes);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string txtProcurar)
        {
            if (!string.IsNullOrEmpty(txtProcurar))
            {
                return View(await _context.Salarios.Include(s => s.Mes).Where(m => m.Mes.Nome.ToUpper().Contains(txtProcurar.ToUpper())).ToListAsync());
            }
            return View(await _context.Salarios.Include(s => s.Mes).ToListAsync());
        }


        // GET: Salario/Create
        public IActionResult Create()
        {
            var dados = _context.Meses.Where(x => x.MesId != x.Salario.MesId).ToList();
            ViewData["MesId"] = new SelectList(dados, "MesId", "Nome");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SalarioDto dadosTemporario)
        {

            if (ModelState.IsValid)
            {
                var mes = _context.Meses.First(d => d.MesId == dadosTemporario.MesId);
                TempData["confirmacao"] = mes.Nome + " foi cadastrado com sucesso.";

                Salario dados = new Salario();
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                _context.Salarios.Add(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var dados = _context.Meses.Where(x => x.MesId != x.Salario.MesId).ToList();
                ViewData["MesId"] = new SelectList(dados, "MesId", "Nome");
                return View("../Salario/Create");
            }

        }

        // GET: Salario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Salarios.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }
            SalarioDto dadosView = new SalarioDto();
            dadosView.SalarioId = dados.SalarioId;
            dadosView.MesId = dados.MesId;
            dadosView.ValorString = dados.Valor.ToString();

            var registro = _context.Meses.Where(x => x.MesId == dados.MesId).ToList();
            ViewData["MesId"] = new SelectList(registro, "MesId", "Nome");

            return View(dadosView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SalarioDto dadosTemporario)
        {

            if (ModelState.IsValid)
            {
                var mes = _context.Meses.First(d => d.MesId == dadosTemporario.MesId);
                TempData["confirmacao"] = mes.Nome + " foi atualizado com sucesso.";

                var dados = await _context.Salarios.FindAsync(dadosTemporario.SalarioId);
                dados.SalarioId = dadosTemporario.SalarioId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", dadosTemporario.MesId);
                return View("../Salario/Edit");
            }


        }


        // POST: Salario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salarioDto = await _context.Salarios.FindAsync(id);
            _context.Salarios.Remove(salarioDto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<JsonResult> Deletar(int id)
        {
            var dados = await _context.Salarios.FindAsync(id);
            TempData["confirmacao"] = dados.Mes.Nome + " foi excluido com sucesso.";
            _context.Salarios.Remove(dados);
            await _context.SaveChangesAsync();
            return Json(dados.Mes + "excluido com sucesso.");
        }

   
    }
}
