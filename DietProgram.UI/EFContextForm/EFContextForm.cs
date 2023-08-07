using DietProgram.BLL.Concrete;
using DietProgram.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.UI.EFContextForm
{
    public static class EFContextForm
    {
        public static IServiceProvider _serviceProvider;

        private static IHostBuilder CreateHostBuilder<T>() where T : class
        {
            var result = Host.CreateDefaultBuilder()
                             .ConfigureServices(services =>
                             {
                                 services.AddScopedBll()
                                         .AddTransient<T>();
                             });

            return result;
        }

        public static Form ConfigureService<T>() where T : Form
        {
            var host = CreateHostBuilder<T>().Build();
            _serviceProvider = host.Services;
            return _serviceProvider.GetRequiredService<T>();

        }
    }
}
