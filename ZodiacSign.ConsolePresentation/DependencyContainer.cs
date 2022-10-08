using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.ConsolePresentation
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddConsolePresentation(this IServiceCollection services)
        {
            services.AddSingleton<ZodiacSign>();
            return services;
        }
    }
}
