using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAsignatura : IGenericInterface<Asignatura>
    {
        Task<IEnumerable<Asignatura>> SubjectsT1Y3I7 ();
        Task<IEnumerable<Asignatura>> SubjectsInGrade4 ();
        Task<IEnumerable<Asignatura>> SubjectsTakenBy26902806M ();
        Task<IEnumerable<Asignatura>> SubjectsWithoutTeacher ();
    }
}