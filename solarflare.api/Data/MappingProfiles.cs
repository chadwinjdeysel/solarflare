

using AutoMapper;

namespace solarflare.api.Data {
    public class MappingProfiles : Profile {
        public MappingProfiles() {
            CreateMap<Entities.Kit, Models.Kit>().ReverseMap();
            CreateMap<Entities.Component, Models.Component>().ReverseMap();
        }
    }
}