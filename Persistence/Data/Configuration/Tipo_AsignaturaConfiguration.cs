using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Tipo_AsignaturaConfiguration : IEntityTypeConfiguration<Tipo_Asignatura>
    {
        public void Configure(EntityTypeBuilder<Tipo_Asignatura> builder)
        {
            builder.ToTable("Tipo_Asignatura");
            builder.Property(p=>p.Tipo).HasColumnName("Tipo").HasMaxLength(50).IsRequired();
        }
    }
}