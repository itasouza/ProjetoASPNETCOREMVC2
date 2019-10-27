using Microsoft.EntityFrameworkCore;
using ProjetoAlbumFotos.Mapeamento;
using ProjetoAlbumFotos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlbumFotos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Imagem> Imagens { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMap()); 
            modelBuilder.ApplyConfiguration(new ImagemMap());

            //restrição para não deletar em cascata
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

    }
}
