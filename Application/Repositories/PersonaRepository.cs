using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Persistence.Data;

namespace Application.Repositories
{
    public class PersonaRepository : GenericRepository<Persona>
    {
        public PersonaRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}