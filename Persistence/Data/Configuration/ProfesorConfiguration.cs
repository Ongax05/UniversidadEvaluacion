using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProfesorConfiguration : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.ToTable("Profesor");
            builder.HasOne(p=>p.Persona).WithMany(p=>p.Profesores).HasForeignKey(p=>p.PersonaId);
            builder.HasOne(p=>p.Departamento).WithMany(p=>p.Profesores).HasForeignKey(p=>p.DepartamentoId);
        }
    }
}