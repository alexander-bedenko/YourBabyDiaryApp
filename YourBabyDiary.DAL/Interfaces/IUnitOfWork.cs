using System;
using System.Threading.Tasks;
using YourBabyDiary.DAL.EF;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<T> Repository<T>() where T : BaseEntity;

        YourBabyDiaryContext Context { get; }

        Task Commit();

        void Rollback();
    }
}