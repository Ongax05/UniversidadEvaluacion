using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Data.Configuration;

namespace API.Controllers
{
    public class DepartamentoController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public DepartamentoController (IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }
        [HttpGet ("DepartmentsWithTeachersTeachingAtGrade4")]
        public async Task<ActionResult<IEnumerable<DepartamentoDto>>> DepartmentsWithTeachersTeachingAtGrade4 ()
        {
            var deps = await unitOfWork.Departamentos.DepartmentsWithTeachersTeachingAtGrade4();
            return mapper.Map<List<DepartamentoDto>>(deps);
        }
        [HttpGet ("DepartmentsWithoutTeachers")]
        public async Task<ActionResult<IEnumerable<DepartamentoDto>>> DepartmentsWithoutTeachers()
        {
            var r = await unitOfWork.Departamentos.DepartmentsWithoutTeachers();
            return mapper.Map<List<DepartamentoDto>>(r);
        }
    }
}