using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public class EventService : CrudService<Event, EventDto>, IEventService
    {
        public EventService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        {
        }
    }
}
