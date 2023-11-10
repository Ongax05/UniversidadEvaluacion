using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Curso_EscolarConfiguration : IEntityTypeConfiguration<Curso_Escolar>
    {
        public void Configure(EntityTypeBuilder<Curso_Escolar> builder)
        {
            builder.ToTable("Curso_Escolar");
            builder.Property(p=>p.Año_Fin).HasColumnName("Año_Fin").HasColumnType("datetime").IsRequired();   
            builder.Property(p=>p.Año_Inicio).HasColumnName("Año_Inicio").HasColumnType("datetime").IsRequired();
        }
    }
}