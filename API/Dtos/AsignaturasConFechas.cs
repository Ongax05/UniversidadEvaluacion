using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class AsignaturasConFechas
    {
        public string Nombre { get; set; }
        public double Creditos { get; set; }
        public byte Curso { get; set; }
        public byte Cuatrimestre { get; set; }
        #nullable enable
        public int ? ProfesorId { get; set; }
        #nullable disable
        public int GradoId { get; set; }
        public int Tipo_AsignaturaId { get; set; }
        public ICollection<SRICjustWithCurso> Alumno_Se_Matricula_Asignaturas { get; set; }
    }
}