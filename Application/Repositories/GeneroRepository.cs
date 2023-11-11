using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Persistence.Data;

namespace Application.Repositories
{
    public class GeneroRepository : GenericRepository<Genero>
    {
        public GeneroRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}