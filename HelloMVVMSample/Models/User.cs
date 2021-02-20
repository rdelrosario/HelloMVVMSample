using System;
using System.ComponentModel;

namespace HelloMVVMSample.Models
{
    public class User : INotifyPropertyChanged
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set;  }
        public string LastName { get; set;  }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
