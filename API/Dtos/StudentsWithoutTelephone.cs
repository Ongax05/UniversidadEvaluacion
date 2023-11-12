using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class StudentsWithoutTelephone
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        #nullable enable
        public string ? Telefono { get; set; }
        public int Tipo_PersonaId { get; set; }
    }
}