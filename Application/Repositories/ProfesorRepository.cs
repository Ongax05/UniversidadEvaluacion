using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class ProfesorRepository : GenericRepository<Profesor>, IProfesor
    {
        private readonly UniversidadDbContext context;
        public ProfesorRepository(UniversidadDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Profesor>> TeachersWithDepartaments ()
        {
            var t = await context.Profesores.Include(s=>s.Persona).Include(s=>s.Departamento).ToListAsync();
            var tids = t.Select(t=>t.PersonaId).ToList();
            var p = await context.Personas.Where(p=> !tids.Contains(p.Id) && p.Tipo_PersonaId == 2).ToListAsync();
            foreach (var tw in p){
                var pr = new Profesor (){
                    PersonaId = tw.Id,
                    Persona = tw,
                    DepartamentoId = 0,
                    Departamento = null
                };
                t.Add(pr);
            }
            return t;
        }
    }
}