using System;
using AutoMapper;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public abstract class BaseService
    {
        protected IMapper _mapper;
        protected readonly IUnitOfWork _uow;

        protected BaseService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _mapper = mapper;
        }
    }
}
