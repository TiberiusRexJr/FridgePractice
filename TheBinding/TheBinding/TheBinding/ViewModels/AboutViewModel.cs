using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TheBinding.ViewModels
{
    public class AboutViewModel : BaseViewModel,INotifyPropertyChanged
    {
        public ICommand OpenWebCommand { get; }
        private bool _adultContent;
        public event PropertyChangedEventHandler PropertyChanged;
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            _adultContent = false; /* in real life get from ojbect persistence*/
        }

        private bool AdultContent
        {
            get =>_adultContent;
            set 
            {
                _adultContent = value;
                OnPropertyChanged(nameof(_adultContent));
            }
        }

        //handler code Operator
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}