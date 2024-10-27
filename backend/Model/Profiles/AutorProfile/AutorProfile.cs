using AutoMapper;
using Model.DTOs.MetaDto;
using Model.Entities;

namespace Model.Profiles.MetaProfile
{
    public class AutorProfile : Profile
    {
        public AutorProfile() 
        {
            CreateMap<Autor, AutorDto>().ReverseMap(); // Mapeamento de Meta para MetaDto
            CreateMap<CreateAutorDto, Autor>().ReverseMap();
        }
    }
}
