using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public class BabyService : CrudService<Baby, BabyDto>, IBabyService
    {
        public BabyService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        {
        }
    }
}
