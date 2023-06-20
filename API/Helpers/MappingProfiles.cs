using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<StarshipCreateDto, Starship>();
            CreateMap<StarshipUpdateDto, Starship>();
        }
    }
}