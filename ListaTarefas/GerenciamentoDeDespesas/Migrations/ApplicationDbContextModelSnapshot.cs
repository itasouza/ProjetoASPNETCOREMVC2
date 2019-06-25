﻿// <auto-generated />
using GerenciamentoDeDespesas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciamentoDeDespesas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.Despesa", b =>
                {
                    b.Property<int>("DespesaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MesId");

                    b.Property<int>("TipoDeDespesaId");

                    b.Property<double>("Valor");

                    b.HasKey("DespesaId");

                    b.HasIndex("MesId");

                    b.HasIndex("TipoDeDespesaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.Mes", b =>
                {
                    b.Property<int>("MesId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MesId");

                    b.ToTable("Meses");
                });

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.Salario", b =>
                {
                    b.Property<int>("SalarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MesId");

                    b.Property<double>("Valor");

                    b.HasKey("SalarioId");

                    b.HasIndex("MesId")
                        .IsUnique();

                    b.ToTable("Salarios");
                });

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.TipoDeDespesa", b =>
                {
                    b.Property<int>("TipoDeDespesaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TipoDeDespesaId");

                    b.ToTable("TipoDeDespesas");
                });

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.Despesa", b =>
                {
                    b.HasOne("GerenciamentoDeDespesas.Models.Mes", "Mes")
                        .WithMany("Despesa")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GerenciamentoDeDespesas.Models.TipoDeDespesa", "TipoDeDespesa")
                        .WithMany("Despesa")
                        .HasForeignKey("TipoDeDespesaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GerenciamentoDeDespesas.Models.Salario", b =>
                {
                    b.HasOne("GerenciamentoDeDespesas.Models.Mes", "Mes")
                        .WithOne("Salario")
                        .HasForeignKey("GerenciamentoDeDespesas.Models.Salario", "MesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
