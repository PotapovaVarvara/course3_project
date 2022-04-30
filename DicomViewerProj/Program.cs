using System;
using System.Windows.Forms;
using BLL;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace NakataniProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Vintasoft.Imaging.ImagingGlobalSettings.Register("Varvara Potapova", "v.o.potapova@student.khai.edu", "2022-05-19", "cLMsG7dsnthXtWoO2k44hZxUl6CgtrHvMn/IMPbuRRr5FzGQ/I0hlUvUOUss3AJ+ArN3VY/8geOO3LE39alLxs78mwTXfive6ZPXiNkxeJahVUJwzhuR8MXB2asA5oN/okwLNU+/Dwy1NXDN4p/2+NXiaZd0M9TlRYICWiCZa6s");


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // ConfigureSerilog();
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<Form1>();
                    services.AddLogging(configure => configure.AddConsole());
                    services.AddScoped<IDbInfrastructurer, DbInfrastructurer>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<IDbRequestExecutor, DbRequestExecutor>();

                  
                }).Build();

            ConfigureSerilog();

            using var serviceScope = host.Services.CreateScope();
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var form1 = services.GetRequiredService<Form1>();

                    Application.Run(form1);
                    
                    Console.WriteLine("Run Form1 is successful");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                        .WriteTo
                        .MSSqlServer(DbManager.GetConnectionWithDb().ConnectionString, "Logs")
                        .CreateLogger();
            Log.Information("Info");
        }

    }
}
