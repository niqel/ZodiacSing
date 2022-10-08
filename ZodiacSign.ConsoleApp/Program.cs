

using Microsoft.Extensions.Hosting;
using ZodiacSign.AppBusiness.UseCases;
using ZodiacSign.AppBusinessImplementations.UseCasesImplementation;
using ZodiacSign.IoC;

namespace ZodiacSign.ConsoleApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddZodiacSignDependencies(context.Configuration);
                }).Build();

            var exe = host.Services.GetService(typeof(ZodiacSign.ConsolePresentation.ZodiacSign));
            host.Run();
        }
    }
}

    


//using var host = Host.CreateDefaultBuilder(args)
//    .ConfigureAppConfiguration((hostingContext, configuration) =>
//    {
//        configuration.Sources.Clear();

//        IHostEnvironment env = hostingContext.HostingEnvironment;

//        configuration
//            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

//        IConfigurationRoot configurationRoot = configuration.Build();
        
//    })
//    .Build();
//host.Services.






//using IHost host = Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingContext, configuration =>));
////using IHost host = Host.CreateDefaultBuilder(args);
//host.Configuration 

//IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json").Build();

//var service = new ServiceCollection();
//service.BuildServiceProvider();
//service.AddZodiacSignDependencies(config);


//Console.WriteLine("SI corre");
//Console.ReadLine();

//await host.RunAsync();