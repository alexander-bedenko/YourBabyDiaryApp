using System;
using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiaryApp.Model;

namespace YourBabyDiaryApp.Infrastructure
{
    public class AutoMapperWebConfig : Profile
    {
        public static readonly Action<IMapperConfigurationExpression> ConfigAction = cfg =>
        {
            cfg.CreateMap<ParentDto, Parent>().ReverseMap();
            cfg.CreateMap<BabyDto, Baby>().ReverseMap();
            cfg.CreateMap<EventDto, Event>().ReverseMap();
        };
    }
}
