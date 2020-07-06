using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xmal_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoard : ContentPage, INotifyPropertyChanged
    {
        string theNote;
        public Command SaveCommand;
        public Command EraseCommand;
        public ObservableCollection<string> AllNotes { get; set; }
        public DashBoard()
        {
            InitializeComponent();
            EraseCommand = new Command(() => { TheNote = string.Empty; });
            SaveCommand = new Command(() => { AllNotes.Add(theNote); theNote = string.Empty; });
        }
        public string TheNote
        {
            get => theNote;

            set{
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(theNote));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}