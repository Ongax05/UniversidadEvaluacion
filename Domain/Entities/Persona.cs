using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : BaseEntity
    {
        public string Nif { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        #nullable enable    
        public string ? Telefono { get; set; }
        #nullable disable
        public DateOnly Fecha_Nacimiento { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public int Tipo_PersonaId { get; set; }
        public Tipo_Persona Tipo_Persona { get; set; }
        public ICollection<Alumno_se_matricula_asignatura> Alumno_Se_Matricula_Asignaturas { get; set; }
        public ICollection<Profesor> Profesores { get; set; }
    }
}