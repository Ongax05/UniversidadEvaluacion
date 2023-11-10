using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AsignaturaConfiguration : IEntityTypeConfiguration<Asignatura>

    {
        public void Configure(EntityTypeBuilder<Asignatura> builder)
        {
            builder.ToTable("Asignatura");
            builder.Property(p=>p.Nombre).HasColumnName("Nombre").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Creditos).HasColumnName("Creditos").HasColumnType("double").IsRequired();
            builder.Property(p=>p.Curso).HasColumnName("Curso").HasColumnType("tinyint").IsRequired();
            builder.Property(p=>p.Cuatrimestre).HasColumnName("Cuatrimestre").HasColumnType("tinyint").IsRequired();
            builder.HasOne(p=>p.Profesor).WithMany(p=>p.Asignaturas).HasForeignKey(p=>p.ProfesorId);
            builder.HasOne(p=>p.Grado).WithMany(p=>p.Asignaturas).HasForeignKey(p=>p.GradoId);
            builder.HasOne(p=>p.Tipo_Asignatura).WithMany(p=>p.Asignaturas).HasForeignKey(p=>p.Tipo_AsignaturaId);
        }
    }
}