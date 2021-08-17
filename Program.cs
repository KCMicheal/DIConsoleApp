using Microsoft.Extensions.DependencyInjection;
using System;

namespace DIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<UserApplication>();
            var serviceProvider = services.BuildServiceProvider();
            var userAppService = serviceProvider.GetService<UserApplication>();
            userAppService.AddUser("John");
            userAppService.AddUser("Sunny");
            var allUsers = userAppService.GetUsers();
            Console.WriteLine($"Registered Users are: {string.Join(", ", allUsers)}");
            Console.ReadLine();
        }
    }
}
