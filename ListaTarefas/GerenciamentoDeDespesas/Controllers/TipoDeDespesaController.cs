using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeDespesas.Data;
using GerenciamentoDeDespesas.Dto;
using GerenciamentoDeDespesas.Models;
using X.PagedList;

namespace GerenciamentoDeDespesas.Controllers
{
    public class TipoDeDespesaController : Controller
    {

        private readonly ApplicationDbContext database;

        public TipoDeDespesaController(ApplicationDbContext database)
        {
            this.database = database;
        }



        //[HttpGet]
        //public IActionResult Index(string busca = "", int pagina = 1, int tamanhoPagina = 5)
        //{
        //    var dados = database.TipoDeDespesas.OrderBy(pro => pro.TipoDeDespesaId).ToPagedList(pagina, tamanhoPagina);
        //    ViewBag.Busca = busca;
        //    ViewBag.TamanhoPagina = tamanhoPagina;

        //    return View(dados);
        //}


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dados = await database.TipoDeDespesas.ToListAsync();
            return View(dados);
        }


        [HttpPost]
        public async Task<IActionResult> Index(string txtProcurar)
        {
            if (!String.IsNullOrEmpty(txtProcurar))
            {
                var dados = await database.TipoDeDespesas.Where(td => td.Nome.ToUpper().Contains(txtProcurar.ToUpper())).ToListAsync();
                txtProcurar = "";
                return View(dados);
            }

            return View(await database.TipoDeDespesas.ToListAsync());
        }


        // GET: TipoDeDespesa/NovoTipoDeDespesa
        public IActionResult Novo()
        {
            return View();
        }


        //validação remota
        public async Task<JsonResult> TipoDespesaExisteAsync(string nome)
        {
            if (await database.TipoDeDespesas.AnyAsync(td => td.Nome.ToUpper() == nome.ToUpper()))
                return Json("Este tipo de despesa já existe!");
            return Json(true);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(TipoDeDespesaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {

                TempData["confirmacao"] = dadosTemporario.Nome + " foi cadastrado com sucesso.";

                TipoDeDespesa dados = new TipoDeDespesa();
                dados.Nome = dadosTemporario.Nome;
                database.TipoDeDespesas.Add(dados);
                database.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("../TipoDeDespesa/Novo");
            }
        }


        public async Task<IActionResult> Atualizar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.TipoDeDespesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            TipoDeDespesaDto dadosView = new TipoDeDespesaDto();
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.Nome = dados.Nome;
            return View(dadosView);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(TipoDeDespesaDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = dadosTemporario.Nome + " foi atualizado com sucesso.";
                var dados = await database.TipoDeDespesas.FindAsync(dadosTemporario.TipoDeDespesaId);
                dados.Nome = dadosTemporario.Nome;
                database.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("../TipoDeDespesa/Atualizar");
            }
        }




        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.TipoDeDespesas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            TipoDeDespesaDto dadosView = new TipoDeDespesaDto();
            dadosView.TipoDeDespesaId = dados.TipoDeDespesaId;
            dadosView.Nome = dados.Nome;
            return View(dadosView);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            var dados = await database.TipoDeDespesas.FindAsync(id);
            TempData["confirmacao"] = dados.Nome + " foi excluido com sucesso.";
            database.TipoDeDespesas.Remove(dados);
            await database.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
