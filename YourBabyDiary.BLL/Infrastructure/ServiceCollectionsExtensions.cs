using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YourBabyDiary.DAL.EF;
using YourBabyDiary.DAL.Extensions;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Infrastructure
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection RegisterBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterRepositories(configuration);
            services.AddScoped<IYourBabyDiaryContext, YourBabyDiaryContext>();

            return services;
        }
    }
}
