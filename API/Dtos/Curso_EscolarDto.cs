using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class Curso_EscolarDto
    {
        public DateOnly Año_Inicio { get; set; }
        public DateOnly Año_Fin { get; set; }
    }
}