using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class UniversidadDbContext : DbContext
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base (options){}
        public DbSet<Alumno_se_matricula_asignatura> Alumno_Se_Matricula_Asignaturas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso_Escolar> Cursos_Escolares { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Tipo_Asignatura> Tipos_Asignaturas { get; set; }
        public DbSet<Tipo_Persona> Tipos_Personas { get; set; }
    }
}