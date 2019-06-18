﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FaixaEtaria.Models;
using ViewData.Models;

namespace FaixaEtaria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            IList<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto { Nome = "Café", Preco = 5.25 });
            produtos.Add(new Produto { Nome = "Leite", Preco = 1.75 });
            produtos.Add(new Produto { Nome = "Açucar", Preco = 3.75 });
            ViewData["RecebeProduto"] = produtos;

            return View();
        }

        public IActionResult Contact()
        {

            ViewData.Add(new KeyValuePair<string, object>("Nome", "Itamar"));
            ViewData.Add(new KeyValuePair<string, object>("Idade", "29"));


            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
