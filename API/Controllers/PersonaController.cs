using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using iText.Layout.Renderer;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonaController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public PersonaController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        [HttpGet("StudentsByNames")]
        public async Task<ActionResult<IEnumerable<JustNamesDto>>> JustStudentsNames()
        {
            var students = await unitOfWork.Personas.StudentsOrderByNames();
            return mapper.Map<List<JustNamesDto>>(students);
        }

        [HttpGet("StudentsWithoutTelephone")]
        public async Task<
            ActionResult<IEnumerable<StudentsWithoutTelephone>>
        > StudentsWithoutTelephone()
        {
            var students = await unitOfWork.Personas.StudentsWithoutTelephone();
            return mapper.Map<List<StudentsWithoutTelephone>>(students);
        }

        [HttpGet("PersonBornIn1999")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> PersonBornIn1999()
        {
            var students = await unitOfWork.Personas.PersonsBornIn1999();
            return mapper.Map<List<PersonaDto>>(students);
        }

        [HttpGet("TeachersWithoutTelephoneAndlastLetterOfNifK")]
        public async Task<
            ActionResult<IEnumerable<PersonaDto>>
        > TeachersWithoutTelephoneAndlastLetterOfNifK()
        {
            var Teachers = await unitOfWork.Personas.TeachersWithoutTelephoneAndlastLetterOfNifK();
            return mapper.Map<List<PersonaDto>>(Teachers);
        }

        [HttpGet("FemaleStudentsRegisteredInGrade4")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> FemaleStudentsRegisteredInGrade4()
        {
            var persons = await unitOfWork.Personas.FemaleStudentsRegisteredInGrade4();
            return mapper.Map<List<PersonaDto>>(persons);
        }

        [HttpGet("TeachersOrderedWithTheirDepartments")]
        public async Task<
            ActionResult<IEnumerable<TeachersWithDepartments>>
        > TeachersOrderedWithTheirDepartments()
        {
            var (teachers, departaments) = await unitOfWork
                .Personas
                .TeachersOrderedWithTheirDepartments();
            List<TeachersWithDepartments> Teachers = new();
            for (int i = 0; i < teachers.Count; i++)
            {
                var dto = new TeachersWithDepartments()
                {
                    Id = teachers[i].Id,
                    Nombre = teachers[i].Nombre,
                    Apellido1 = teachers[i].Apellido1,
                    Apellido2 = teachers[i].Apellido2,
                    Departamento = departaments[i]
                };
                Teachers.Add(dto);
            }
            return Teachers.OrderBy(t => t.Nombre).ThenBy(t => t.Apellido1).ToList();
        }

        [HttpGet("StudentsEnrolledBetween2018And2019")]
        public async Task<
            ActionResult<IEnumerable<PersonaDto>>
        > StudentsEnrolledBetween2018And2019()
        {
            var persons = await unitOfWork.Personas.StudentsEnrolledBetween2018And2019();
            return mapper.Map<List<PersonaDto>>(persons);
        }

        [HttpGet("TeachersWhoAreNotTeaching")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> TeachersWhoAreNotTeaching()
        {
            var Persona = await unitOfWork.Personas.TeachersWhoAreNotTeaching();
            return mapper.Map<List<PersonaDto>>(Persona);
        }

        [HttpGet("TotalFemaleStudents")]
        public async Task<ActionResult<int>> TotalFemaleStudents()
        {
            return await unitOfWork.Personas.TotalFemaleStudents();
        }

        [HttpGet("StudentsBornIn1999")]
        public async Task<ActionResult<int>> StudentsBornIn1999()
        {
            return await unitOfWork.Personas.StudentsBornIn1999();
        }

        [HttpGet("YoungestStudent")]
        public async Task<ActionResult<PersonaDto>> YoungestStudent()
        {
            var r = await unitOfWork.Personas.YoungestStudent();
            return mapper.Map<PersonaDto>(r);
        }

        [HttpGet("TeachersWithoutDepartament")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> TeachersWithoutDepartament()
        {
            var r = await unitOfWork.Personas.TeachersWithoutDepartament();
            return mapper.Map<List<PersonaDto>>(r);
        }

        [HttpGet("TeachersWithDepartmentNotTeaching")]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> TeachersWithDepartmentNotTeaching()
        {
            var r = await unitOfWork.Personas.TeachersWithDepartmentNotTeaching();
            if (r == null)
            {
                List<Persona> p = new();
                return mapper.Map<List<PersonaDto>>(p);
            }
            return mapper.Map<List<PersonaDto>>(r);
        }
    }
}
