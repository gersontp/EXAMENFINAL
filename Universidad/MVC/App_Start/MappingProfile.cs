using AutoMapper;
using MVC.DTO;
using Universidad.Context.Clases;

namespace Universidad.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Alumno, AlumnoDTO>();
            CreateMap<AlumnoDTO, Alumno>();

            CreateMap<EstadoCivil, EstadoCivilDTO>();
            CreateMap<EstadoCivilDTO, EstadoCivil>();

            CreateMap<Genero, GeneroDTO>();
            CreateMap<GeneroDTO, Genero>();
        }
    }
}