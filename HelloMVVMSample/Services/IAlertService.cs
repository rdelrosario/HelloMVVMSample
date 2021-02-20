using System;
using System.Threading.Tasks;

namespace HelloMVVMSample.Services
{
    public interface IAlertService
    {
        Task AlertAsync(string title, string description);
    }
}
