using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeDespesas.Data;
using GerenciamentoDeDespesas.Dto;
using GerenciamentoDeDespesas.Models;

namespace GerenciamentoDeDespesas.Controllers
{
    public class TipoDeDespesaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoDeDespesaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoDeDespesa
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDeDespesas.ToListAsync());
        }

        // GET: TipoDeDespesa/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TipoDeDespesaDto dadosTemporario)
        {

            if (ModelState.IsValid)
            {

                TempData["confirmacao"] = dadosTemporario.Nome + " foi cadastrado com sucesso.";
                TipoDeDespesa dados = new TipoDeDespesa();
                dados.Nome = dadosTemporario.Nome;
                _context.TipoDeDespesas.Add(dados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("../TipoDeDespesa/Create");
            }

        }

        // GET: TipoDeDespesa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.TipoDeDespesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }
            TipoDeDespesaDto dadosView = new TipoDeDespesaDto();
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.Nome = dados.Nome;
            return View(dadosView);
        }

        // POST: TipoDeDespesa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TipoDeDespesaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = dadosTemporario.Nome + " foi atualizado com sucesso.";
                var dados = await _context.TipoDeDespesas.FindAsync(dadosTemporario.TipoDeDespesaId);
                dados.Nome = dadosTemporario.Nome;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("../TipoDeDespesa/Edit");
            }
        }

 

        [HttpPost]
        public async Task<JsonResult> Deletar(int id)
        {
            var dados = await _context.TipoDeDespesas.FindAsync(id);
            TempData["confirmacao"] = dados.Nome + " foi excluido com sucesso.";
            _context.TipoDeDespesas.Remove(dados);
            await _context.SaveChangesAsync();
            return Json(dados.Nome + "excluido com sucesso.");
        }



        public async Task<JsonResult> TipoDespesaExisteAsync(string nome)
        {
            if (await _context.TipoDeDespesas.AnyAsync(td => td.Nome.ToUpper() == nome.ToUpper()))
                return Json("Este tipo de despesa já existe!");
            return Json(true);
        }
    }
}
