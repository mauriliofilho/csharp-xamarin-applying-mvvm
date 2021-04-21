using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            Command cmd = UpdateApplicationCommand;
        }

        public string Title { get; set; } = "Roster App";

        public Command UpdateApplicationCommand { get; }


        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                //
            }

            remove
            {
                //
            }
        }
    }
}
