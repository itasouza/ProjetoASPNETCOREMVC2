using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoExemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoExemplo.Mapeamento
{
    public class ImagemMap : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            //HasKey = chave primária
            builder.HasKey(td => td.ImagemId);
            //HasMaxLength = tamanho do campo
            //IsRequired = requerido
            builder.Property(td => td.Link).HasMaxLength(50).IsRequired();

            //Imagem pertence a 1 album
            builder.HasOne(d => d.Album).WithMany(d => d.Imagens).HasForeignKey(d => d.AlbumId);
            //ToTable = nome da tabela
            builder.ToTable("Imagens");
        }
    }
}