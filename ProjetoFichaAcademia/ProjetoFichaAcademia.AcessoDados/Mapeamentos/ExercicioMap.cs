using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFichaAcademia.AcessoDados.Mapeamentos
{
    public class ExercicioMap : IEntityTypeConfiguration<Exercicio>
    {
        public void Configure(EntityTypeBuilder<Exercicio> builder)
        {
            builder.HasKey(e => e.ExercicioId);

            builder.Property(e => e.Nome).HasMaxLength(50).IsRequired();

            builder.HasOne(e => e.CategoriaExercicio).WithMany(e => e.Exercicios).HasForeignKey(e => e.CategoriaExercicioId);
            builder.HasMany(e => e.ListaExercicios).WithOne(e => e.Exercicio);

            builder.ToTable("Exercicios");
        }
    }
}