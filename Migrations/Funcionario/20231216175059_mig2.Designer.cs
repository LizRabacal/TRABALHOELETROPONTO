﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRABALHOELETROPONTO.Data;

#nullable disable

namespace TRABALHOELETROPONTO.Migrations.Funcionario
{
    [DbContext(typeof(FuncionarioContext))]
    [Migration("20231216175059_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TRABALHOELETROPONTO.Models.Funcionario", b =>
                {
                    b.Property<int>("ID_FUNC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CARGO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DATA_ADMISSAO")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NOME_FUNC")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float?>("SALARIO")
                        .HasColumnType("float");

                    b.Property<string>("TELEFONE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID_FUNC");

                    b.ToTable("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
