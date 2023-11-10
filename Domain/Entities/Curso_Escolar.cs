using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Curso_Escolar : BaseEntity
    {
        public DateOnly Año_Inicio { get; set; }
        public DateOnly Año_Fin { get; set; }
        public ICollection<Alumno_se_matricula_asignatura> Alumno_Se_Matricula_Asignaturas { get; set; }
    }
}