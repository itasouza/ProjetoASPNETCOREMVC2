using IntermediarioFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediarioFluentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //HasKey indica a chave da tabela
            //HasColumnName nome da coluna
            //HasColumnType tipo da coluna
            //HasMaxLength tamanho máximo da coluna
            //IsRequired o campo e requerido ou não
            //ToTable indica o nome da tabela

            modelBuilder.Entity<Pessoa>().HasKey(x => x.PessoaID);
            modelBuilder.Entity<Pessoa>().Property(x => x.Nome).HasColumnName("Nome").HasColumnType("nText").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pessoa>().Property(x => x.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired(false);
            modelBuilder.Entity<Pessoa>().Property(x => x.Peso).HasColumnName("Peso").HasColumnType("float").IsRequired(false);

            //relacionameno não obrigatório 
            //HasOne = tem um 
            //WithOne = com um
            //HasForeignKey = Possui chave estrangeira
            modelBuilder.Entity<Pessoa>().HasOne(x => x.Endereco).WithOne(x => x.Pessoa).HasForeignKey<Pessoa>(x => x.EnderecoId);
            modelBuilder.Entity<Endereco>().HasOne(x => x.Pessoa).WithOne(x => x.Endereco);

            modelBuilder.Entity<Pessoa>().ToTable("Pessoas");

        }

    }
}
