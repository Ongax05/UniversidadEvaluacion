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
    public class GradoRepository : GenericRepository<Grado>, IGrado
    {
        public GradoRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}