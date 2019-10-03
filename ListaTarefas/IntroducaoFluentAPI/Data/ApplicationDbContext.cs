using IntroducaoFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoFluentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasKey(x => x.PessoaID);
            modelBuilder.Entity<Pessoa>().Property(x => x.Nome).HasColumnName("Nome").HasColumnType("nText").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pessoa>().Property(x => x.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired(false);
            modelBuilder.Entity<Pessoa>().Property(x => x.Peso).HasColumnName("Peso").HasColumnType("float").IsRequired(false);
            modelBuilder.Entity<Pessoa>().ToTable("Pessoas");

        }

    }
}
