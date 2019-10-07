using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.BLL.Interfaces
{
    public interface IEventService : ICrudService<Event, EventDto>
    {
    }
}