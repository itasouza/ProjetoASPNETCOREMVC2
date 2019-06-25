using GerenciamentoDeDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Mapeamento
{
    public class SalarioMap : IEntityTypeConfiguration<Salario>
    {
        public void Configure(EntityTypeBuilder<Salario> builder)
        {
            builder.HasKey(s => s.SalarioId);
            builder.Property(s => s.Valor).IsRequired();

            //1 salário tem 1 mês
            builder.HasOne(s => s.Mes).WithOne(s => s.Salario).HasForeignKey<Salario>(s => s.MesId);

            builder.ToTable("Salarios");
        }
    }
}
