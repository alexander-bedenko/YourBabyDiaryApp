using System;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork _uow;

        protected BaseService(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }
    }
}
