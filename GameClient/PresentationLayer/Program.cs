using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces;
using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var registrationForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(registrationForm);

            }

          

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGameBusiness, GameBusiness>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<LoginForm>();
        

        }

    }
}
