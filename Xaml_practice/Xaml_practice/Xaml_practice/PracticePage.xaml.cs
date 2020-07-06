using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaml_practice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracticePage : ContentPage,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command SaveButton;
        public Command DeleteButton;
        ObservableCollection<string> Notes;
        string theNote;
        public PracticePage()
        {
            InitializeComponent();
            SaveButton = new Command(() => { Notes.Add(theNote); theNote = string.Empty; });
            DeleteButton = new Command(() => { TheNote = string.Empty; });
        }
        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(theNote));
                PropertyChanged?.Invoke(this, args);
            }

    }
}