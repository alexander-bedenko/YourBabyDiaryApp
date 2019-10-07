using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YourBabyDiary.DAL.EF;
using YourBabyDiary.DAL.Interfaces;
using YourBabyDiary.DAL.Repository;

namespace YourBabyDiary.DAL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(DbContext), typeof(YourBabyDiaryContext));
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<YourBabyDiaryContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                });

            return services;
        }
    }
}
