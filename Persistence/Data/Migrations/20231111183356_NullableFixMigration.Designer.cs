﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(UniversidadDbContext))]
    [Migration("20231111183356_NullableFixMigration")]
    partial class NullableFixMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Alumno_se_matricula_asignatura", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<int>("Curso_EscolarId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("AsignaturaId", "Curso_EscolarId", "PersonaId");

                    b.HasIndex("Curso_EscolarId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Alumno_Se_Matricula_Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Creditos")
                        .HasColumnType("double");

                    b.Property<byte>("Cuatrimestre")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("Curso")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("GradoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_AsignaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradoId");

                    b.HasIndex("ProfesorId");

                    b.HasIndex("Tipo_AsignaturaId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Curso_Escolar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Año_Fin")
                        .HasColumnType("date");

                    b.Property<DateOnly>("Año_Inicio")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Cursos_Escolares");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Domain.Entities.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Grados");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido1")
                        .HasColumnType("longtext");

                    b.Property<string>("Apellido2")
                        .HasColumnType("longtext");

                    b.Property<string>("Ciudad")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Fecha_Nacimiento")
                        .HasColumnType("date");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nif")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.Property<int>("Tipo_PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.HasIndex("Tipo_PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Domain.Entities.Tipo_Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Tipo_Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Personas");
                });

            modelBuilder.Entity("Domain.Entities.Alumno_se_matricula_asignatura", b =>
                {
                    b.HasOne("Domain.Entities.Asignatura", "Asignatura")
                        .WithMany("Alumno_Se_Matricula_Asignaturas")
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Curso_Escolar", "Curso_Escolar")
                        .WithMany("Alumno_Se_Matricula_Asignaturas")
                        .HasForeignKey("Curso_EscolarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("Alumno_Se_Matricula_Asignaturas")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("Curso_Escolar");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Domain.Entities.Asignatura", b =>
                {
                    b.HasOne("Domain.Entities.Grado", "Grado")
                        .WithMany("Asignaturas")
                        .HasForeignKey("GradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Profesor", "Profesor")
                        .WithMany("Asignaturas")
                        .HasForeignKey("ProfesorId");

                    b.HasOne("Domain.Entities.Tipo_Asignatura", "Tipo_Asignatura")
                        .WithMany("Asignaturas")
                        .HasForeignKey("Tipo_AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grado");

                    b.Navigation("Profesor");

                    b.Navigation("Tipo_Asignatura");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.Genero", "Genero")
                        .WithMany("Personas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Tipo_Persona", "Tipo_Persona")
                        .WithMany("Personas")
                        .HasForeignKey("Tipo_PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Tipo_Persona");
                });

            modelBuilder.Entity("Domain.Entities.Profesor", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamento")
                        .WithMany("Profesores")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("Profesores")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Domain.Entities.Asignatura", b =>
                {
                    b.Navigation("Alumno_Se_Matricula_Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Curso_Escolar", b =>
                {
                    b.Navigation("Alumno_Se_Matricula_Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Profesores");
                });

            modelBuilder.Entity("Domain.Entities.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Grado", b =>
                {
                    b.Navigation("Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("Alumno_Se_Matricula_Asignaturas");

                    b.Navigation("Profesores");
                });

            modelBuilder.Entity("Domain.Entities.Profesor", b =>
                {
                    b.Navigation("Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Tipo_Asignatura", b =>
                {
                    b.Navigation("Asignaturas");
                });

            modelBuilder.Entity("Domain.Entities.Tipo_Persona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}