using System;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace HelloMVVMSample.Services
{
    public class AlertService : IAlertService
    {
        public Task AlertAsync(string title, string description)
        {
            return UserDialogs.Instance.AlertAsync( description, title, "Ok");

           // UserDialogs.Instance.Toast($"{title} : {description}");

            //return Task.CompletedTask;
        }
    }
}
