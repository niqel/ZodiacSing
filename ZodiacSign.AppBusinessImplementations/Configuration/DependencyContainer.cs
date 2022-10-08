using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.UseCases;
using ZodiacSign.AppBusinessImplementations.UseCasesImplementation;

namespace ZodiacSign.AppBusinessImplementations.Configuration
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesContainer(this IServiceCollection services)
        {
            services.AddTransient<IGetSignByBirthday, GetSignByBirthday>();
            services.AddTransient<IGetAllSigns, GetAllSigns>();
            services.AddTransient<IPresenter, Presenter>();
            return services;
        }
    }
}
