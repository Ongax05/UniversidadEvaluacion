using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDepartamento : IGenericInterface<Departamento>
    {
        Task<IEnumerable<Departamento>> DepartmentsWithTeachersTeachingAtGrade4 ();
        Task <IEnumerable<Departamento>> DepartmentsWithoutTeachers();
    }
}