using GerenciamentoDeDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Mapeamento
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.HasKey(d => d.DespesaId);
            builder.Property(d => d.Valor).IsRequired();

            //1 despesa tem 1 mês , 1 Mês para várias despesas
            builder.HasOne(d => d.Mes).WithMany(d => d.Despesa).HasForeignKey(d => d.MesId);
            builder.HasOne(d => d.TipoDeDespesa).WithMany(d => d.Despesa).HasForeignKey(d => d.TipoDeDespesaId);


            builder.ToTable("Despesas");
        }
    }
}
