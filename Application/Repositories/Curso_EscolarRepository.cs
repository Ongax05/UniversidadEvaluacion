using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Persistence.Data;

namespace Application.Repositories
{
    public class Curso_EscolarRepository : GenericRepository<Curso_Escolar>
    {
        public Curso_EscolarRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}