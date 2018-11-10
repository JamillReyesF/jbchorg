﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jbchorg.Models;

namespace jbchorg.Migrations
{
    [DbContext(typeof(JbchorgDBContext))]
    [Migration("20181109175938_fin")]
    partial class fin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("jbchorg.Models.Asociado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AMaterno");

                    b.Property<string>("APaterno");

                    b.Property<string>("Area");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("GAcademico");

                    b.Property<string>("Genero");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("TAsociadoId");

                    b.HasKey("Id");

                    b.HasIndex("TAsociadoId");

                    b.ToTable("Asociados");
                });

            modelBuilder.Entity("jbchorg.Models.Donacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AMaterno")
                        .IsRequired();

                    b.Property<string>("APaterno")
                        .IsRequired();

                    b.Property<string>("Banco")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("DNI")
                        .IsRequired();

                    b.Property<string>("Monto")
                        .IsRequired();

                    b.Property<string>("Movil")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Tarjeta")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Donacion");
                });

            modelBuilder.Entity("jbchorg.Models.Mensaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AMaterno");

                    b.Property<string>("APaterno");

                    b.Property<string>("Asunto");

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Movil");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Mensaje");
                });

            modelBuilder.Entity("jbchorg.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime>("Duracion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("jbchorg.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreServ")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("descripcion");

                    b.Property<string>("tipo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("jbchorg.Models.TAsociado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TAsociados");

                    b.HasData(
                        new { Id = 1, Nombre = "Principal" },
                        new { Id = 2, Nombre = "Adjunto" },
                        new { Id = 3, Nombre = "Invitado" }
                    );
                });

            modelBuilder.Entity("jbchorg.Models.Asociado", b =>
                {
                    b.HasOne("jbchorg.Models.TAsociado", "TAsociado")
                        .WithMany("Asociados")
                        .HasForeignKey("TAsociadoId");
                });
#pragma warning restore 612, 618
        }
    }
}