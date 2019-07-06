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
using System.Globalization;
using X.PagedList;

namespace GerenciamentoDeDespesas.Controllers
{
    public class DespesaController : Controller
    {
        private readonly ApplicationDbContext database;

        public DespesaController(ApplicationDbContext database)
        {
            this.database = database;
        }



        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPagina = 10;
            int numeroPagina = (pagina ?? 1);

            var dados = database.Despesas.Include(s => s.Mes).Include(d => d.TipoDeDespesa).OrderBy(d => d.MesId);
           // return View(await dados.ToPagedListAsync(numeroPagina,itensPagina));
            return View(await dados.ToListAsync());
        }



        public IActionResult Novo()
        {
            ViewBag.Mes = database.Meses.ToList();
            ViewBag.TipoDespesa = database.TipoDeDespesas.ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(DespesaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {

                TempData["confirmacao"] = " Despesa foi cadastrado com sucesso.";

                Despesa dados = new Despesa();
                dados.TipoDeDespesaId = dadosTemporario.TipoDeDespesaId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                database.Despesas.Add(dados);
                database.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Mes = database.Meses.ToList();
                ViewBag.TipoDespesa = database.TipoDeDespesas.ToList();
                return View("../Despesa/Novo");
            }
        }


        public async Task<IActionResult> Atualizar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.Despesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            ViewBag.Mes = database.Meses.ToList();
            ViewBag.TipoDespesa = database.TipoDeDespesas.ToList();

            DespesaDto dadosView = new DespesaDto();
            dadosView.DespesaId = dados.DespesaId;
            dadosView.MesId = dados.MesId;
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.ValorString = dados.Valor.ToString();
            return View(dadosView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(DespesaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = " Despesa atualizado com sucesso.";

                var dados = await database.Despesas.FindAsync(dadosTemporario.DespesaId);
                dados.TipoDeDespesaId = dadosTemporario.TipoDeDespesaId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                database.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            else
            {
                ViewBag.Mes = database.Meses.ToList();
                ViewBag.TipoDespesa = database.TipoDeDespesas.ToList();
                return View("../Despesa/Atualizar");
            }
        }



        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.Despesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            ViewBag.Mes = database.Meses.ToList();
            ViewBag.TipoDespesa = database.TipoDeDespesas.ToList();



            DespesaDto dadosView = new DespesaDto();
            dadosView.DespesaId = dados.DespesaId;
            dadosView.MesId = dados.MesId;
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.ValorString = dados.Valor.ToString();
            return View(dadosView);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            var dados = await database.Despesas.FindAsync(id);

            TempData["confirmacao"] = "Despesa foi excluido com sucesso.";

            database.Despesas.Remove(dados);
            await database.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}