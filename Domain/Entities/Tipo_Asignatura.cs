using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tipo_Asignatura : BaseEntity
    {
        public string Tipo { get; set; }
        public ICollection<Asignatura> Asignaturas { get; set; }
    }
}