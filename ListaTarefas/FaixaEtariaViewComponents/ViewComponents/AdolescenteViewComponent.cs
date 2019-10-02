﻿using FaixaEtariaViewComponents.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtariaViewComponents.ViewComponents
{
    public class AdolescenteViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public AdolescenteViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.PESSOA.Where( x => x.Idade < 18).ToListAsync());
        }



    }
}
