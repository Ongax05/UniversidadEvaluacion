using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class PersonaRepository : GenericRepository<Persona>, IPersona
    {
        private readonly UniversidadDbContext context;

        public PersonaRepository(UniversidadDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Persona>> FemaleStudentsRegisteredInGrade4()
        {
            var subjects = await context
                .Asignaturas
                .Where(s => s.GradoId == 4)
                .Select(s => s.Id)
                .ToListAsync();
            var registeredpersonsids = await context
                .Alumno_Se_Matricula_Asignaturas
                .Where(r => subjects.Contains(r.AsignaturaId))
                .Select(r => r.PersonaId)
                .ToListAsync();
            var persons = await context
                .Personas
                .Where(p => registeredpersonsids.Contains(p.Id))
                .ToListAsync();
            var Women = persons.Where(p => p.GeneroId == 2);
            return Women;
        }

        public async Task<IEnumerable<Persona>> PersonsBornIn1999()
        {
            var people = await context
                .Personas
                .Where(p => p.Fecha_Nacimiento.Year == 1999)
                .ToListAsync();
            return people;
        }

        public async Task<IEnumerable<Persona>> StudentsOrderByNames()
        {
            var Students = await context
                .Personas
                .Where(p => p.Tipo_Persona.Tipo == "Alumno")
                .ToListAsync();
            return Students
                .OrderBy(p => p.Apellido1)
                .ThenBy(p => p.Apellido2)
                .ThenBy(p => p.Nombre);
        }

        public async Task<IEnumerable<Persona>> StudentsWithoutTelephone()
        {
            var students = await context
                .Personas
                .Where(p => p.Tipo_Persona.Tipo == "Alumno" && p.Telefono == null)
                .ToListAsync();
            return students.OrderBy(p => p.Nombre);
        }

        public async Task<IEnumerable<Persona>> TeachersWithoutTelephoneAndlastLetterOfNifK()
        {
            var Teachers = await context
                .Personas
                .Where(p => p.Tipo_PersonaId == 2 && p.Nif.EndsWith("K"))
                .ToListAsync();
            return Teachers;
        }

        public async Task<(
            List<Persona> teachers,
            List<string> departaments
        )> TeachersOrderedWithTheirDepartments()
        {
            var Teachers = await context.Profesores.Include(t => t.Departamento).ToListAsync();
            var ids = Teachers.Select(p => p.PersonaId);
            var persons = await context.Personas.Where(p => ids.Contains(p.Id)).ToListAsync();
            var departaments = Teachers.Select(t => t.Departamento.Nombre).ToList();

            return (persons, departaments);
        }

        public async Task<IEnumerable<Persona>> StudentsEnrolledBetween2018And2019()
        {
            var cursosId = await context
                .Cursos_Escolares
                .Where(c => c.Año_Inicio.Year >= 2018 && c.Año_Fin.Year <= 2019)
                .Select(c => c.Id)
                .ToListAsync();
            var r = await context
                .Alumno_Se_Matricula_Asignaturas
                .Where(r => cursosId.Contains(r.Curso_EscolarId))
                .Select(r => r.PersonaId)
                .ToListAsync();
            var persons = await context.Personas.Where(p => r.Contains(p.Id)).ToListAsync();
            return persons;
        }

        public async Task<IEnumerable<Persona>> TeachersWhoAreNotTeaching()
        {
            var ids = await context.Profesores.Select(p => p.Id).ToListAsync();
            var p = await context
                .Personas
                .Where(p => p.Tipo_PersonaId == 2 && !ids.Contains(p.Id))
                .ToListAsync();
            return p;
        }

        public async Task<int> TotalFemaleStudents()
        {
            var r = await context.Personas.Where(p => p.GeneroId == 2).ToListAsync();
            return r.Count;
        }

        public async Task<int> StudentsBornIn1999()
        {
            var r = await context
                .Personas
                .Where(p => p.Fecha_Nacimiento.Year == 1999)
                .ToListAsync();
            return r.Count;
        }

        public async Task<Persona> YoungestStudent()
        {
            var r = await context
                .Personas
                .Where(p => p.Tipo_PersonaId == 1)
                .OrderByDescending(p => p.Fecha_Nacimiento)
                .FirstOrDefaultAsync();
            return r;
        }

        public async Task<IEnumerable<Persona>> TeachersWithoutDepartament()
        {
            var r = await context.Profesores.Select(p => p.PersonaId).ToListAsync();
            var p = await context
                .Personas
                .Where(p => !r.Contains(p.Id) && p.Tipo_PersonaId == 2)
                .ToListAsync();
            return p;
        }

        public async Task<IEnumerable<Persona>> TeachersWithDepartmentNotTeaching()
        {
            var teacherIdsWithSubjects = await context
                .Asignaturas
                .Where(a => a.Profesor != null)
                .Select(a => a.Profesor.PersonaId)
                .ToListAsync();

            var teachersWithoutSubjects = await context
                .Profesores
                .Where(p => !teacherIdsWithSubjects.Contains(p.PersonaId))
                .ToListAsync();

            var teacherIdsWithoutSubjects = teachersWithoutSubjects
                .Select(p => p.PersonaId)
                .ToList();

            var teachersWithoutSubjectsPersons = await context
                .Personas
                .Where(p => teacherIdsWithoutSubjects.Contains(p.Id))
                .ToListAsync();

            return teachersWithoutSubjectsPersons;
        }
    }
}
