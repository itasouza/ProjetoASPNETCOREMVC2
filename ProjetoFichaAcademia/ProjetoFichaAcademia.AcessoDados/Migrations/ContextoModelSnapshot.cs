﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFichaAcademia.AcessoDados;

namespace ProjetoFichaAcademia.AcessoDados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Administrador", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("AdministradorId");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FrequenciaSemanal");

                    b.Property<int>("Idade");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("ObjetivoId");

                    b.Property<double>("Peso");

                    b.Property<int>("ProfessorId");

                    b.HasKey("AlunoId");

                    b.HasIndex("ObjetivoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.CategoriaExercicio", b =>
                {
                    b.Property<int>("CategoriaExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoriaExercicioId");

                    b.ToTable("CategoriasExercicios");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaExercicioId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ExercicioId");

                    b.HasIndex("CategoriaExercicioId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Ficha", b =>
                {
                    b.Property<int>("FichaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId");

                    b.Property<DateTime>("Cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("Validade");

                    b.HasKey("FichaId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Fichas");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.ListaExercicio", b =>
                {
                    b.Property<int>("ListaExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Carga");

                    b.Property<int>("ExercicioId");

                    b.Property<int>("FichaId");

                    b.Property<int>("Frequencia");

                    b.Property<int>("Repeticoes");

                    b.HasKey("ListaExercicioId");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("FichaId");

                    b.ToTable("ListasExercicios");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Objetivo", b =>
                {
                    b.Property<int>("ObjetivoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ObjetivoId");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("ProfessorId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.Objetivo", "Objetivo")
                        .WithMany("Alunos")
                        .HasForeignKey("ObjetivoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Exercicio", b =>
                {
                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.CategoriaExercicio", "CategoriaExercicio")
                        .WithMany("Exercicios")
                        .HasForeignKey("CategoriaExercicioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.Ficha", b =>
                {
                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.Aluno", "Aluno")
                        .WithMany("Fichas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoFichaAcademia.Dominio.Models.ListaExercicio", b =>
                {
                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.Exercicio", "Exercicio")
                        .WithMany("ListaExercicios")
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoFichaAcademia.Dominio.Models.Ficha", "Ficha")
                        .WithMany("ListaExercicios")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
