using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Starship, StarshipDto>();
            CreateMap<Film, FilmShipDto>()
                .ForMember(dest => dest.FilmId,
                    opt => opt.MapFrom(src => src.Id));
            CreateMap<StarshipCreateDto, Starship>();
            CreateMap<StarshipUpdateDto, Starship>();
        }
    }
}