using GerenciamentoDeDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Mapeamento
{
    public class TipoDespesaMap : IEntityTypeConfiguration<TipoDeDespesa>
    {
        public void Configure(EntityTypeBuilder<TipoDeDespesa> builder)
        {
            builder.HasKey(td => td.TipoDeDespesaId);
            builder.Property(td => td.Nome).HasMaxLength(50).IsRequired();

            //1 tipo de despesa tem várias despesas
            builder.HasMany(td => td.Despesa).WithOne(td => td.TipoDeDespesa).HasForeignKey(td => td.TipoDeDespesaId);
            builder.ToTable("TipoDeDespesas");
        }


    }
}
