using GerenciamentoDeDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Mapeamento
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesId);
            //banco não vai gerar o id do mês
            builder.Property(m => m.MesId).ValueGeneratedNever();
            builder.Property(m => m.Nome).HasMaxLength(50).IsRequired();

            //1 mês tem várias despesa, se excluir 1 mês, vai escluir todas as desapesas do Mês excluido
            builder.HasMany(m => m.Despesa).WithOne(m => m.Mes).HasForeignKey(m => m.MesId).OnDelete(DeleteBehavior.Cascade);
            //1 mês tem 1 salário
            builder.HasOne(m => m.Salario).WithOne(m => m.Mes).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Meses");
        }
    }
}
