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

namespace GerenciamentoDeDespesas.Controllers
{
    public class SalarioController : Controller
    {
        private readonly ApplicationDbContext database;

        public SalarioController(ApplicationDbContext database)
        {
            this.database = database;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dados = database.Salarios.Include(s => s.Mes); 
            return View(await dados.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Index(string txtProcurar)
        {
            if (!String.IsNullOrEmpty(txtProcurar))
            {
                var dadosPesquisa = await database.Salarios.Include(x => x.Mes).Where(td => td.Mes.Nome.ToUpper().Contains(txtProcurar.ToUpper())).ToListAsync();
                txtProcurar = "";
                return View(dadosPesquisa);
            }

            var dados = database.Salarios.Include(s => s.Mes); 
            return View(await dados.ToListAsync());
        }


        public IActionResult Novo()
        {
            //lista os meses que não foram utilizados
            ViewBag.Mes = database.Meses.Where(x => x.MesId != x.Salario.MesId) .ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(SalarioDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var mes = database.Meses.First(d => d.MesId == dadosTemporario.MesId);
                TempData["confirmacao"] = mes.Nome + " foi cadastrado com sucesso.";

                Salario dados = new Salario();
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                database.Salarios.Add(dados);
                database.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Mes = database.Meses.ToList();
                return View("../Salario/Novo");
            }
        }



        public async Task<IActionResult> Atualizar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.Salarios.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            ViewBag.Mes = database.Meses.Where(x => x.MesId == dados.MesId).ToList();

            SalarioDto dadosView = new SalarioDto();
            dadosView.SalarioId = dados.SalarioId;
            dadosView.MesId = dados.MesId;
            dadosView.ValorString = dados.Valor.ToString();
            return View(dadosView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(SalarioDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                var mes = database.Meses.First(d => d.MesId == dadosTemporario.MesId);
                TempData["confirmacao"] = mes.Nome + " foi atualizado com sucesso.";

                var dados = await database.Salarios.FindAsync(dadosTemporario.SalarioId);
                dados.SalarioId = dadosTemporario.SalarioId;
                dados.MesId = dadosTemporario.MesId;
                dados.Valor = float.Parse(dadosTemporario.ValorString, CultureInfo.InvariantCulture.NumberFormat);
                database.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Mes = database.Meses.ToList();
                return View("../Salario/Atualizar");
            }
        }


        public async Task<IActionResult> Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await database.Salarios.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            ViewBag.Mes = database.Meses.Where(x => x.MesId == x.Salario.MesId).ToList();
        

            SalarioDto dadosView = new SalarioDto();
            dadosView.SalarioId = dados.SalarioId;
            dadosView.MesId = dados.MesId;
            dadosView.ValorString = dados.Valor.ToString();
            return View(dadosView);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            var dados = await database.Salarios.FindAsync(id);

            var mes = database.Meses.First(d => d.MesId == dados.MesId);
            TempData["confirmacao"] = mes.Nome + " foi excluido com sucesso.";

            database.Salarios.Remove(dados);
            await database.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
