using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using FoolOrGenius.Db;
using System.Configuration;
using FoolOrGenius.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace FoolOrGeniusWinFormsApp
{
    internal static class Program
    {
        private static IHost host;
        //private static User existingUser;
        public static IServiceProvider Services { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connection = ConfigurationManager.ConnectionStrings["FoolOrGenius"].ConnectionString;

            host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<UserFactory>();
                    services.AddTransient<WelcomeForm>();
                    services.AddTransient<RegisterForm>();
                    services.AddTransient<mainForm>();
                    services.AddTransient<GameService>();
                    services.AddSingleton<DiagnoseCalculator>();
                    services.AddDbContext<DatabaseContext>(options =>
                        options.UseSqlServer(connection), ServiceLifetime.Singleton);
                })
                .Build();

            Services = host.Services;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(host.Services.GetRequiredService<WelcomeForm>());

        }
    }
}
