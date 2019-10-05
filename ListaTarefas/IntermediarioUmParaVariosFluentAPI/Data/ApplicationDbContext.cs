using IntermediarioUmParaVariosFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediarioUmParaVariosFluentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Trabalho> Trabalhos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //relacionameno não obrigatório 
        //HasOne = tem um 
        //WithOne = com um
        //HasForeignKey = Possui chave estrangeira

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empregado>().HasOne(e => e.Trabalho).WithMany(e => e.Empregado).HasForeignKey(e => e.TrabalhoId);
            modelBuilder.Entity<Trabalho>().HasMany(t => t.Empregado).WithOne(t => t.Trabalho);


        }


    }
}
