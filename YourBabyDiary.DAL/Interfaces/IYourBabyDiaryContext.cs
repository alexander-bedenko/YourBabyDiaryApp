using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using YourBabyDiary.DAL.Entities;

namespace YourBabyDiary.DAL.Interfaces
{
    public interface IYourBabyDiaryContext
    {
        DbSet<Parent> Parents { get; set; }
        DbSet<Baby> Babies { get; set; }
        DbSet<Event> Events { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        void Dispose();
        EntityEntry Entry(object entity);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<T> Set<T>() where T : class;
    }
}