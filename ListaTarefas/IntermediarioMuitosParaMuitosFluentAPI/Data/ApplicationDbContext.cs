using IntermediarioMuitosParaMuitosFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediarioMuitosParaMuitosFluentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Trabalho> Trabalhos { get; set; }
        public DbSet<EmpregadoTrabalho> EmpregadosTrabalhos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Empregado está relacionado a 1 ou vários emprego_trabalho
        //emprego_trabalho está relacionado apenas 1 Empregado
        //Trabalho está relacionado a um ou vários Emprego_trabalho
        //emprego_trabalho está relacionado apenas 1 Trabalho

        //relacionameno não obrigatório 
        //HasOne = tem um 
        //WithOne = com um
        //HasForeignKey = Possui chave estrangeira

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpregadoTrabalho>().HasKey(x => new { x.EmpregadoId, x.TrabalhoId });
            modelBuilder.Entity<EmpregadoTrabalho>().HasOne(x => x.Empregado).WithMany(x => x.EmpregadoTrabalho).HasForeignKey(x => x.EmpregadoId);
            modelBuilder.Entity<EmpregadoTrabalho>().HasOne(x => x.Trabalho).WithMany(x => x.EmpregadoTrabalho).HasForeignKey(x => x.TrabalhoId);

        }


    }
}
