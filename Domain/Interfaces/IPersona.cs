using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPersona : IGenericInterface<Persona>
    {
        Task<IEnumerable<Persona>> StudentsOrderByNames ();
        Task<IEnumerable<Persona>> StudentsWithoutTelephone();
        Task<IEnumerable<Persona>> PersonsBornIn1999 ();
        Task<IEnumerable<Persona>> TeachersWithoutTelephoneAndlastLetterOfNifK ();
        Task<IEnumerable<Persona>> FemaleStudentsRegisteredInGrade4 ();
        Task<(List<Persona> teachers, List<string> departaments)> TeachersOrderedWithTheirDepartments();
        Task<IEnumerable<Persona>> StudentsEnrolledBetween2018And2019 ();
        Task<IEnumerable<Persona>>  TeachersWhoAreNotTeaching();
        Task <int> TotalFemaleStudents ();
        Task <int> StudentsBornIn1999 ();
        Task <Persona> YoungestStudent();
        Task <IEnumerable<Persona>> TeachersWithoutDepartament ();
        Task<IEnumerable<Persona>> TeachersWithDepartmentNotTeaching ();
    }
}