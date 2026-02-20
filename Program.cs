using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Controllers;
using TaskManagement.DBConnection;
using TaskManagement.Forms;
using TaskManagement.Services.Implementation;
using TaskManagement.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace TaskManagement
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: false).Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IDbConnectionFactory, PostgresConnectionFactory>();
            services.AddSingleton<DatabaseExecutor>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<LoginController>();
            services.AddScoped<TaskController>();

            services.AddTransient<LoginForm>();
            services.AddTransient<AdminDashboard>();
            services.AddTransient<EmployeeDashboard>();
            services.AddTransient<ForgetPassForm>();
            services.AddTransient<EditForm>();

            ServiceProvider = services.BuildServiceProvider();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}