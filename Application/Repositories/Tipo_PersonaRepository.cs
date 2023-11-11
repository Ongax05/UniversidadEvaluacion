using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class Tipo_PersonaRepository : GenericRepository<Tipo_Persona>, ITipo_Persona
    {
        public Tipo_PersonaRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}