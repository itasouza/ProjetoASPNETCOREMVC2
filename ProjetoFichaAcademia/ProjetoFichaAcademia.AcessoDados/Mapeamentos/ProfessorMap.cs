﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFichaAcademia.AcessoDados.Mapeamentos
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(p => p.ProfessorId);

            builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Turno).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Foto).IsRequired();
            builder.Property(p => p.Telefone).IsRequired();

            builder.HasMany(p => p.Alunos).WithOne(p => p.Professor);

            builder.ToTable("Professores");
        }
    }
}