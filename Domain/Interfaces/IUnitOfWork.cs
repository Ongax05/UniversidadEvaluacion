using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAsignatura Asignaturas { get; }
        ICurso_Escolar Curso_Escolares { get; }
        IDepartamento Departamentos { get; }
        IGenero Generos { get; }
        IGrado Grados { get; }
        IPersona Personas { get; }
        IProfesor Profesores { get; }
        ITipo_Asignatura Tipo_Asignaturas { get; }
        ITipo_Persona Tipo_Personas { get; }
    }
}