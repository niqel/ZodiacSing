using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZodiacSign.Domain.IRepositories;
using ZodiacSign.Persistence.Configurations.DbContext;
using ZodiacSign.Persistence.Repositories;

namespace ZodiacSign.Persistence.Configurations
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPersistencyContainer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ZodiacSignDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ZodiacSignConnection")));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnityOfWork, UnityOfWork>();
            return services;
        }
    }
}
