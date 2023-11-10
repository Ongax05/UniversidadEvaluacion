using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Alumno_se_matricula_asignatura
    {
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
        public int Curso_EscolarId { get; set; }
        public Curso_Escolar Curso_Escolar { get; set; }
    }
}