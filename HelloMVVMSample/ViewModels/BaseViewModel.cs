using System.ComponentModel;
using HelloMVVMSample.Services;

namespace HelloMVVMSample.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public IAlertService AlertService { get; }

        protected BaseViewModel(IAlertService alertService)
        {
            AlertService = alertService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
