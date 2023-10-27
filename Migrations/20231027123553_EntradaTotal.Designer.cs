﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCinema.Models;

#nullable disable

namespace ProjetoCinema.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231027123553_EntradaTotal")]
    partial class EntradaTotal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoCinema.Models.Bomboniere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BomboniereId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bebidas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Bebidas");

                    b.Property<string>("Guloseimas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Guloseimas");

                    b.Property<string>("Pipocas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pipocas");

                    b.HasKey("Id");

                    b.ToTable("Bomboniere");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CadastroId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("Entrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Entrada");

                    b.Property<string>("EscolhaFilme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EscolhaFilme");

                    b.Property<DateTime>("HrSessao")
                        .HasColumnType("datetime2")
                        .HasColumnName("HrSessao");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Lugar");

                    b.Property<string>("Pedidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pedidos");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Total");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("ProjetoCinema.Models.EspecialHorror", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HorrorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classificacao")
                        .HasColumnType("int")
                        .HasColumnName("Classificacao");

                    b.Property<string>("Filmes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Filmes");

                    b.Property<DateTime>("HrSesssao")
                        .HasColumnType("datetime2")
                        .HasColumnName("HrSesssao");

                    b.HasKey("Id");

                    b.ToTable("EspecialHorror");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FilmesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FilmeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeNome");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("Idade");

                    b.Property<DateTime>("SesssaoHora")
                        .HasColumnType("datetime2")
                        .HasColumnName("SesssaoHora");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}