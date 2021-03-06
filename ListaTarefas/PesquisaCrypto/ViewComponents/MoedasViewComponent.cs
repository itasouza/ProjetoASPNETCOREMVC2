﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PesquisaCrypto.ViewComponets
{
    public class MoedasViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public MoedasViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.MOEDA.ToListAsync());
        }

    }
}
