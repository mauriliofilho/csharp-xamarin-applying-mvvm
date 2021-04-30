using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Roster.Client.Models;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationCommandExecute);
            People = new ObservableCollection<Person>
            {
                new Person{ Name = "Delores Feil", Company = "Legros Group"},
                new Person{ Name = "Ann Zboncak", Company = "Ledner - Ferry"},
                new Person{ Name = "Jaime Lesch", Company = "Herzog and Sons"}
            };
        }

        private void UpdateApplicationCommandExecute()
        {
            Title = "Roster App (v2.0)";
            
        }

        private String _title = "Roster App";
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Person> People { get; set; }

        public Command UpdateApplicationCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
