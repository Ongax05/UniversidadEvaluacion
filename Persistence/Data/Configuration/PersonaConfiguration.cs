using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.Property(p=>p.Nif).HasColumnName("Nif").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Nombre).HasColumnName("Nombre").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Apellido1).HasColumnName("Apellido1").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Apellido2).HasColumnName("Apellido2").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Ciudad).HasColumnName("Ciudad").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Direccion).HasColumnName("Direccion").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Telefono).HasColumnName("Telefono").HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Fecha_Nacimiento).HasColumnName("Fecha_Nacimiento").HasColumnType("datetime").IsRequired();
            builder.HasOne(p=>p.Genero).WithMany(p=>p.Personas).HasForeignKey(p=>p.GeneroId);
            builder.HasOne(p=>p.Tipo_Persona).WithMany(p=>p.Personas).HasForeignKey(p=>p.Tipo_PersonaId);
        }
    }
}