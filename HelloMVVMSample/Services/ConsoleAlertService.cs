using System;
using System.Threading.Tasks;

namespace HelloMVVMSample.Services
{
    public class ConsoleAlertService : IAlertService
    {
        public Task AlertAsync(string title, string description)
        {
            System.Console.WriteLine($"{title} : {description}");

            return Task.CompletedTask;
        }
    }
}
