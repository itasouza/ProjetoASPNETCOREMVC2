﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacaoDados.Models;

namespace ValidacaoDados.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pessoa> PESSOA { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
