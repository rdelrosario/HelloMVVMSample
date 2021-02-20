using System;
using System.ComponentModel;
using System.Windows.Input;
using HelloMVVMSample.Models;
using HelloMVVMSample.Services;
using Xamarin.Forms;

namespace HelloMVVMSample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get;  }
        public ICommand CountCommand { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Title { get; } = "Test";

        public User User { get; set; } = new User("Juan", "Perez");

        public int Count { get; set; }

        public MainViewModel(IAlertService alertService) : base(alertService)
        {
            LoginCommand = new Command(OnLogin);

            CountCommand = new Command(OnCount);
        }

        private async void OnLogin()
        {
            if (string.IsNullOrEmpty(User.FirstName) ||  string.IsNullOrEmpty(User.LastName))
            {

                await AlertService.AlertAsync("Alert", "Hay campos vacios");
            }
            else
            {

                await AlertService.AlertAsync("Alert", $"{User.FirstName} - {User.LastName}");
            }

        }
        
        private void OnCount()
        {
            Count++;
            User.FirstName = "Pedro";
        }
    }
}
