using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Profesor : BaseEntity
    {
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Asignatura> Asignaturas { get; set; }
    }
}