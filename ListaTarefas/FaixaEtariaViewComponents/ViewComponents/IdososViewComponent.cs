﻿using FaixaEtaria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtariaViewComponents.ViewComponents
{
    public class IdososViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public IdososViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.PESSOA.Where( x => x.Idade > 60).ToListAsync());
        }



    }
}
