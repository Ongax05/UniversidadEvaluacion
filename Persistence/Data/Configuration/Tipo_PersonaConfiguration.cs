using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Tipo_PersonaConfiguration : IEntityTypeConfiguration<Tipo_Persona>
    {
        public void Configure(EntityTypeBuilder<Tipo_Persona> builder)
        {
            builder.ToTable("Tipo_Persona");
            builder.Property(p=>p.Tipo).HasColumnName("Tipo").HasMaxLength(50).IsRequired();
        }
    }
}