using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.BLL.Infrastructure
{
    public class AutoMapperWebProfile : Profile
    {
        public void MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ParentDto, Parent>().ReverseMap();
            CreateMap<BabyDto, Baby>().ReverseMap();
            CreateMap<EventDto, Event>().ReverseMap();
        }
    }
}
