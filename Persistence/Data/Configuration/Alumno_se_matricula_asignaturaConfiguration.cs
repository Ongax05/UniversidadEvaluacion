using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Alumno_se_matricula_asignaturaConfiguration : IEntityTypeConfiguration<Alumno_se_matricula_asignatura>
    {
        public void Configure(EntityTypeBuilder<Alumno_se_matricula_asignatura> builder)
        {
            builder.ToTable("Alumno_se_matricula_asignatura");
            builder.HasOne(p=>p.Persona).WithMany(p=>p.Alumno_Se_Matricula_Asignaturas).HasForeignKey(p=>p.PersonaId);
            builder.HasOne(p=>p.Asignatura).WithMany(p=>p.Alumno_Se_Matricula_Asignaturas).HasForeignKey(p=>p.AsignaturaId);
            builder.HasOne(p=>p.Curso_Escolar).WithMany(p=>p.Alumno_Se_Matricula_Asignaturas).HasForeignKey(p=>p.Curso_EscolarId);
        }
    }
}