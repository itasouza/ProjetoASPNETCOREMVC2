﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoExemplo.Data;

namespace ProjetoExemplo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191031131329_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoExemplo.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FotoTopo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AlbumId");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("ProjetoExemplo.Models.Imagem", b =>
                {
                    b.Property<int>("ImagemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ImagemId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("ProjetoExemplo.Models.Imagem", b =>
                {
                    b.HasOne("ProjetoExemplo.Models.Album", "Album")
                        .WithMany("Imagens")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
