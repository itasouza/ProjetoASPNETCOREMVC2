using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeDespesas.Data;
using GerenciamentoDeDespesas.Models;
using GerenciamentoDeDespesas.Dto;
using System.Globalization;
using GerenciamentoDeDespesas.ViewsModels;
using X.PagedList;

namespace GerenciamentoDeDespesas.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DespesaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Despesa
        public async Task<IActionResult> Index(int? pagina)
        {

            const int itensPagina = 10;
            int numeroPagina = (pagina ?? 1);

            ViewBag.Mes = new SelectList(_context.Meses.Where(x => x.MesId == x.Salario.MesId), "MesId", "Nome");

            var contexto = _context.Despesas.Include(d => d.Mes).Include(d => d.TipoDeDespesa);
            return View(await contexto.ToListAsync());
        }


        // GET: Despesa/Create
        public IActionResult Create()
        {
            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome");
            ViewData["TipoDeDespesaId"] = new SelectList(_context.TipoDeDespesas, "TipoDeDespesaId", "Nome");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DespesaDto dadosTemporario)
        {

            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = " Despesa foi cadastrado com sucesso.";

                Despesa dados = new Despesa();
                dados.TipoDeDespesaId = dadosTemporario.TipoDeDespesaId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                _context.Despesas.Add(dados);
                _context.Add(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", dadosTemporario.MesId);
                ViewData["TipoDeDespesaId"] = new SelectList(_context.TipoDeDespesas, "TipoDeDespesaId", "Nome", dadosTemporario.TipoDeDespesaId);
                return View("../Despesa/Create");
            }

        }

        // GET: Despesa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Despesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }
            DespesaDto dadosView = new DespesaDto();
            dadosView.DespesaId = dados.DespesaId;
            dadosView.MesId = dados.MesId;
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.ValorString = dados.Valor.ToString();

            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", dadosView.MesId);
            ViewData["TipoDeDespesaId"] = new SelectList(_context.TipoDeDespesas, "TipoDeDespesaId", "Nome", dadosView.TipoDeDespesaId);

            return View(dadosView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DespesaDto dadosTemporario)
        {

            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = " Despesa atualizado com sucesso.";

                var dados = await _context.Despesas.FindAsync(dadosTemporario.DespesaId);
                dados.TipoDeDespesaId = dadosTemporario.TipoDeDespesaId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", dadosTemporario.MesId);
                ViewData["TipoDeDespesaId"] = new SelectList(_context.TipoDeDespesas, "TipoDeDespesaId", "Nome", dadosTemporario.TipoDeDespesaId);

                return View("../Despesa/Edit");
            }

        }


        [HttpPost]
        public async Task<JsonResult> Deletar(int id)
        {
            var dados = await _context.Despesas.FindAsync(id);

            TempData["confirmacao"] = "Despesa foi excluido com sucesso.";
            _context.Despesas.Remove(dados);
            await _context.SaveChangesAsync();
            return Json(dados.Mes + "excluido com sucesso.");
        }




        public JsonResult GestaoTotalMes(int mesId)
        {
            GastosTotaisMesViewsModel gastos = new GastosTotaisMesViewsModel();
            gastos.ValorTotalGasto = _context.Despesas.Where(d => d.Mes.MesId == mesId).Sum(d => d.Valor);
            gastos.Salario = _context.Salarios.Where(s => s.Mes.MesId == mesId).Select(s => s.Valor).FirstOrDefault();
            return Json(gastos);

        }
    }
}
