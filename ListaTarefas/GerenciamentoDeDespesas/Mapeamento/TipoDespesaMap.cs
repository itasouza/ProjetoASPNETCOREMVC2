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
            //HasKey = chave primária
            builder.HasKey(td => td.TipoDeDespesaId);
            //HasMaxLength = tamanho do campo
            //IsRequired = requerido
            builder.Property(td => td.Nome).HasMaxLength(50).IsRequired();

            //1 tipo de despesa tem várias despesas
            //WithOne = despesa possui apenas 1 tipo de despesa
            //HasForeignKey = chave estrangeira na tabela de despesa
            builder.HasMany(td => td.Despesa).WithOne(td => td.TipoDeDespesa).HasForeignKey(td => td.TipoDeDespesaId);
            //ToTable = nome da tabela
            builder.ToTable("TipoDeDespesas");
        }


    }
}
