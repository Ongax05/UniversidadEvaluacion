using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Asignatura : BaseEntity
    {
        public string Nombre { get; set; }
        public double Creditos { get; set; }
        public byte Curso { get; set; }
        public byte Cuatrimestre { get; set; }
        #nullable enable
        public int ? ProfesorId { get; set; }
        public Profesor ? Profesor { get; set; }
        #nullable disable
        public int GradoId { get; set; }
        public Grado Grado { get; set; }
        public int Tipo_AsignaturaId { get; set; }
        public Tipo_Asignatura Tipo_Asignatura { get; set; }
        public ICollection<Alumno_se_matricula_asignatura> Alumno_Se_Matricula_Asignaturas { get; set; }
    }
}