using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Persona, JustNamesDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>().ReverseMap();
            CreateMap<Persona, StudentsWithoutTelephone>().ReverseMap();
            CreateMap<Asignatura, AsignaturaDto>().ReverseMap();
            CreateMap<Asignatura, AsignaturasConFechas>().ReverseMap();
            CreateMap<Curso_Escolar, Curso_EscolarDto>().ReverseMap();
            CreateMap<Alumno_se_matricula_asignatura, SRICjustWithCurso>().ReverseMap();
            CreateMap<Departamento, DepartamentoDto>().ReverseMap();
            CreateMap<Profesor, TWDDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Persona.Nombre))
                .ForMember(dest => dest.Apellido1, opt => opt.MapFrom(src => src.Persona.Apellido1))
                .ForMember(dest => dest.Apellido2, opt => opt.MapFrom(src => src.Persona.Apellido2))
                .ForMember(dest => dest.Departamento, opt => opt.MapFrom(src => src.Departamento.Nombre));;
        }
    }
}
