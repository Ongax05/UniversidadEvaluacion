using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tipo_Persona : BaseEntity
    {
        public string Tipo { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}