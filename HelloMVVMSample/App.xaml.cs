using System;
using HelloMVVMSample.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloMVVMSample.Views;

namespace HelloMVVMSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var user = new User("Rendy", "Del Rosario");

            var userString = JsonConvert.SerializeObject(user);


            var deserializerUser = JsonConvert.DeserializeObject<User>(userString);
           // System.Console.WriteLine();
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }
    }
}
