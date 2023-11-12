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
    public class AsignaturaRepository : GenericRepository<Asignatura>, IAsignatura
    {
        private readonly UniversidadDbContext context;

        public AsignaturaRepository(UniversidadDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Asignatura>> SubjectsInGrade4()
        {
            var subjects = await context.Asignaturas.Where(s => s.GradoId == 4).ToListAsync();
            return subjects;
        }

        public async Task<IEnumerable<Asignatura>> SubjectsT1Y3I7()
        {
            var subjects = await context
                .Asignaturas
                .Where(s => s.Cuatrimestre == 1 && s.Curso == 3 && s.GradoId == 7)
                .ToListAsync();
            return subjects;
        }

        public async Task<IEnumerable<Asignatura>> SubjectsTakenBy26902806M()
        {
            var person = await context.Personas.FirstOrDefaultAsync(p => p.Nif == "26902806M");
            var r = await context
                .Alumno_Se_Matricula_Asignaturas
                .Where(a => a.PersonaId == person.Id)
                .ToListAsync();
            var SubjectsId = r.Select(p => p.AsignaturaId).ToList();
            var Subjects = await context
                .Asignaturas
                .Where(a => SubjectsId.Contains(a.Id))
                .Include(
                    a => a.Alumno_Se_Matricula_Asignaturas
                    .Where(v => v.PersonaId == person.Id)
                )
                .ThenInclude(a => a.Curso_Escolar)
                .ToListAsync();
            return Subjects;
        }

        public async Task<IEnumerable<Asignatura>> SubjectsWithoutTeacher()
        {
            var r = await context.Asignaturas.Where(a=>a.ProfesorId == null).ToListAsync();
            return r;
        }
    }
}
