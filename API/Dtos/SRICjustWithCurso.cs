using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class SRICjustWithCurso
    {
        public int Curso_EscolarId { get; set; }
        public Curso_EscolarDto Curso_Escolar { get; set; }
    }
}