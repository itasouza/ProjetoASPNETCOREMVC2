using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FaixaEtaria.Models;

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


            //usando o TempData para guardar informações
            TempData["nome"] = "itamar";
            TempData["idade"] = 29;

            string nome;
            int idade;

            if (TempData.ContainsKey("nome"))
                nome = TempData["nome"].ToString();

            if (TempData.ContainsKey("idade"))
                idade = int.Parse(TempData["idade"].ToString());

            //manter os dados
            TempData.Keep();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            string nome;
            int idade;

            if (TempData.ContainsKey("nome"))
                nome = TempData["nome"].ToString();

            if (TempData.ContainsKey("idade"))
                idade = int.Parse(TempData["idade"].ToString());


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
