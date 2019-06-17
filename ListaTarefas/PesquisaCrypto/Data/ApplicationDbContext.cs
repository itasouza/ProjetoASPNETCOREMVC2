using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Moeda> MOEDA { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
