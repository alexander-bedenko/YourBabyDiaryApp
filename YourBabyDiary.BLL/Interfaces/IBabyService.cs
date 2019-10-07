using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.BLL.Interfaces
{
    public interface IBabyService : ICrudService<Baby, BabyDto>
    {
    }
}