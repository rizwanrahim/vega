using AutoMapper;
using Project.Models;
using Project.Models.Resource;

namespace Project.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Makes, MakeResource>();
            CreateMap<Model,ModelResource>();
        }
    }
}