using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AsignaturaController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public AsignaturaController (IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        [HttpGet ("SubjectsT1Y3I7")]
        public async Task<ActionResult<IEnumerable<AsignaturaDto>>> SubjectsT1Y3I7 ()
        {
            var subjects = await unitOfWork.Asignaturas.SubjectsT1Y3I7();
            return mapper.Map<List<AsignaturaDto>>(subjects);
        }
        [HttpGet ("SubjectsInGrade4")]
        public async Task<ActionResult<IEnumerable<AsignaturaDto>>> SubjectsInGrade4 ()
        {
            var subjects = await unitOfWork.Asignaturas.SubjectsInGrade4();
            return mapper.Map<List<AsignaturaDto>> (subjects);
        }
        [HttpGet ("SubjectsTakenBy26902806M")]
        public async Task<ActionResult<IEnumerable<AsignaturasConFechas>>> SubjectsTakenBy26902806M ()
        {
            var subjects = await unitOfWork.Asignaturas.SubjectsTakenBy26902806M ();
            return mapper.Map<List<AsignaturasConFechas>>(subjects);

        }
        [HttpGet ("SubjectsWithoutTeacher")]
        public async Task<ActionResult<IEnumerable<AsignaturaDto>>> SubjectsWithoutTeacher (){
            var s = await unitOfWork.Asignaturas.SubjectsWithoutTeacher();
            return mapper.Map<List<AsignaturaDto>>(s);
        }
    }
}