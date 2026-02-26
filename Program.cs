using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Controllers;
using TaskManagement.Forms;
using TaskManagementCore.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using TaskManagement.Services;
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

            var services = new ServiceCollection();
            
            services.AddHttpClient<IUserService, ApiUserService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7152/");
            });

            services.AddHttpClient<ITaskService, ApiTaskService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7152/");
            });
            services.AddScoped<LoginController>();
            services.AddScoped<TaskController>();

            services.AddTransient<LoginForm>();
            services.AddTransient<AdminDashboard>();
            services.AddTransient<EmployeeDashboard>();
            services.AddTransient<ForgetPassForm>();
            services.AddTransient<EditForm>();

            ServiceProvider = services.BuildServiceProvider();
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