using System;
using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.BLL.Infrastructure
{
    public class AutoMapperBllConfig : Profile
    {
        public static readonly Action<IMapperConfigurationExpression> ConfigAction = cfg =>
        {
            cfg.CreateMap<ParentDto, Parent>().ReverseMap();
            cfg.CreateMap<BabyDto, Baby>().ReverseMap();
            cfg.CreateMap<EventDto, Event>().ReverseMap();
        };
    }
}
