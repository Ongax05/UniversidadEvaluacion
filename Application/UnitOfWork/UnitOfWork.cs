using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly UniversidadDbContext context;
        public UnitOfWork(UniversidadDbContext c)
        {
            context = c;
        }

        private IAsignatura _Asignaturas;
        public IAsignatura Asignaturas
        {
            get
            {
                _Asignaturas ??= new AsignaturaRepository(context);
                return _Asignaturas;
            }
        }

        private ICurso_Escolar _Curso_Escolares;
        public ICurso_Escolar Curso_Escolares
        {
            get
            {
                _Curso_Escolares ??= new Curso_EscolarRepository(context);
                return _Curso_Escolares;
            }
        }


        private IDepartamento _Departamentos;
        public IDepartamento Departamentos
        {
            get
            {
                _Departamentos ??= new DepartamentoRepository(context);
                return _Departamentos;
            }
        }

        private IGenero _Generos;
        public IGenero Generos
        {
            get
            {
                _Generos ??= new GeneroRepository(context);
                return _Generos;
            }
        }

        private IGrado _Grados;
        public IGrado Grados
        {
            get
            {
                _Grados ??= new GradoRepository(context);
                return _Grados;
            }
        }

        private IPersona _Personas;
        public IPersona Personas
        {
            get
            {
                _Personas ??= new PersonaRepository(context);
                return _Personas;
            }
        }

        private IProfesor _Profesores;
        public IProfesor Profesores
        {
            get
            {
                _Profesores ??= new ProfesorRepository(context);
                return _Profesores;
            }
        }


        private ITipo_Persona _Tipo_Personas;
        public ITipo_Persona Tipo_Personas
        {
            get
            {
                _Tipo_Personas ??= new Tipo_PersonaRepository(context);
                return _Tipo_Personas;
            }
        }

        private ITipo_Asignatura _Tipo_Asignaturas;
        public ITipo_Asignatura Tipo_Asignaturas
        {
            get
            {
                _Tipo_Asignaturas ??= new Tipo_AsignaturaRepository(context);
                return _Tipo_Asignaturas;
            }
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}