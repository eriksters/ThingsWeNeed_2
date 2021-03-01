using AutoMapper;
using ThingsWeNeed.API.Dtos;
using ThingsWeNeed.DataLogic.Models;

namespace ThingsWeNeed.API.Profiles
{
    public class ThingsProfile : Profile
    {
        public ThingsProfile() {
            CreateMap<ThingCreateDto, Thing>();
            CreateMap<Thing, ThingGetDto>();
        }
    }
}