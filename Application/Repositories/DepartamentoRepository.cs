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
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        private readonly UniversidadDbContext context;
        public DepartamentoRepository(UniversidadDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Departamento>> DepartmentsWithoutTeachers()
        {
            var r = await context.Profesores.Select(p=>p.DepartamentoId).ToListAsync();
            var d = await context.Departamentos.Where(d=> !r.Contains(d.Id)).ToListAsync();
            return d;
        }

        public async Task<IEnumerable<Departamento>> DepartmentsWithTeachersTeachingAtGrade4()
        {
            var ProfesorsIds = await context.Asignaturas.Where(a=>a.GradoId == 4).Select(s=>s.ProfesorId).Distinct().ToListAsync();
            var departaments = await context.Profesores.Where(p=> ProfesorsIds.Contains(p.Id)).Select(d=>d.Departamento).ToListAsync();
            return departaments;
        }
    }
}