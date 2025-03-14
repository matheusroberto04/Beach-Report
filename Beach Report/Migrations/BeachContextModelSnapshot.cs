﻿// <auto-generated />
using System;
using Beach_Report.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Beach_Report.Migrations
{
    [DbContext(typeof(BeachContext))]
    partial class BeachContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Beach_Report.Models.Descricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDescricao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("Data_Do_Reporte");

                    b.Property<string>("DescricaoReportar")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_Do_Reporte");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ReportarId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("ReportarId");

                    b.ToTable("Tabela_Descricao");
                });

            modelBuilder.Entity("Beach_Report.Models.Reportar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescricaoReportar")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Descricao_Relato");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("Data_Da_Postagem");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Tabela_De_Reportes");
                });

            modelBuilder.Entity("Beach_Report.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CPF")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CPF");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome_De_Usuario");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Senha_Hash");

                    b.Property<int>("Telefone")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Telefone");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Email");

                    b.HasKey("Id");

                    b.ToTable("Tabela_Usuario");
                });

            modelBuilder.Entity("Beach_Report.Models.Descricao", b =>
                {
                    b.HasOne("Beach_Report.Models.Usuario", "Usuario")
                        .WithMany("Descricao")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Beach_Report.Models.Reportar", "Reportar")
                        .WithMany("Descricaos")
                        .HasForeignKey("ReportarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reportar");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Beach_Report.Models.Reportar", b =>
                {
                    b.HasOne("Beach_Report.Models.Usuario", "Usuario")
                        .WithMany("Reportars")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Beach_Report.Models.Reportar", b =>
                {
                    b.Navigation("Descricaos");
                });

            modelBuilder.Entity("Beach_Report.Models.Usuario", b =>
                {
                    b.Navigation("Descricao");

                    b.Navigation("Reportars");
                });
#pragma warning restore 612, 618
        }
    }
}
