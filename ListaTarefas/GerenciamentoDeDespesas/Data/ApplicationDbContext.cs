using GerenciamentoDeDespesas.Mapeamento;
using GerenciamentoDeDespesas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeDespesas.Dto;

namespace GerenciamentoDeDespesas.Data
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Mes> Meses { get; set; }
        public DbSet<Salario> Salarios { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<TipoDeDespesa> TipoDeDespesas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MesMap());
            modelBuilder.ApplyConfiguration(new SalarioMap());
            modelBuilder.ApplyConfiguration(new DespesaMap());
            modelBuilder.ApplyConfiguration(new TipoDespesaMap());
        }



    }
}
