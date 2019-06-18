using FaixaEtaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pessoa> PESSOA { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
