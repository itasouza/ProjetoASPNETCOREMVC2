﻿using System;
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




        public IActionResult Novo()
        {
            ViewBag.Mes = database.Meses.ToList();
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
              //  dados.Valor = float.Parse(dadosTemporario.Valor, CultureInfo.InvariantCulture.NumberFormat);
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

            ViewBag.Mes = database.Meses.ToList();

            SalarioDto dadosView = new SalarioDto();
            dadosView.SalarioId = dados.SalarioId;
            dadosView.MesId = dados.MesId;
            dadosView.Valor = dados.Valor;
            return View(dadosView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(SalarioDto dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = dadosTemporario.Mes.Nome + " foi atualizado com sucesso.";
                var dados = await database.Salarios.FindAsync(dadosTemporario.SalarioId);
                dados.SalarioId = dados.SalarioId;
                dados.MesId = dados.MesId;
                dados.Valor = dados.Valor;
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

            SalarioDto dadosView = new SalarioDto();
            dadosView.SalarioId = dados.SalarioId;
            dadosView.MesId = dados.MesId;
            dadosView.Valor = dados.Valor;
            return View(dadosView);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            var dados = await database.Salarios.FindAsync(id);
            TempData["confirmacao"] = dados.Mes.Nome + " foi excluido com sucesso.";
            database.Salarios.Remove(dados);
            await database.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}