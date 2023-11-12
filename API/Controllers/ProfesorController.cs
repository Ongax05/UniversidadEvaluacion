using API.Dtos;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProfesorController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProfesorController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        [HttpGet ("TeacherWithDepartaments")]
        public async Task <ActionResult<IEnumerable<TWDDto>>> TeacherWithDepartaments()
        {
            var pr = await unitOfWork.Profesores.TeachersWithDepartaments();
            return mapper.Map<List<TWDDto>>(pr);
        }
    }
}