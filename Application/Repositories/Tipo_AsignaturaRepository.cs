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
    public class Tipo_AsignaturaRepository : GenericRepository<Tipo_Asignatura>, ITipo_Asignatura
    {
        public Tipo_AsignaturaRepository(UniversidadDbContext context) : base(context)
        {
        }
    }
}