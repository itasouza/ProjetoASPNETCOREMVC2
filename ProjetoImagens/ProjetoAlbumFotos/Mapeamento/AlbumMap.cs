using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAlbumFotos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAlbumFotos.Mapeamento
{
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            //HasKey = chave primária
            builder.HasKey(td => td.AlbumId);
            //HasMaxLength = tamanho do campo
            //IsRequired = requerido
            builder.Property(td => td.Destino).HasMaxLength(50).IsRequired();
            builder.Property(td => td.FotoTopo).HasMaxLength(50).IsRequired();
            builder.Property(td => td.DataInicio).IsRequired();
            builder.Property(td => td.DataFim).IsRequired();


            //1 album tem várias imagens
            //WithOne = album possui apenas 1 tipo de imagens
            //HasForeignKey = chave estrangeira na tabela de imagens
            builder.HasMany(td => td.Imagens).WithOne(td => td.Album).HasForeignKey(td => td.AlbumId); 
            //ToTable = nome da tabela
            builder.ToTable("Albuns");
        }
    }
}
