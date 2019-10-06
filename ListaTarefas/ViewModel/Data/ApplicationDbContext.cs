using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Models;

namespace ViewModel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
