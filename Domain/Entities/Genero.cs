using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Genero : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
}