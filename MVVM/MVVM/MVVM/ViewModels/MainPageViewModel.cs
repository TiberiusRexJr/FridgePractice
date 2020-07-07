using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MVVM.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            var NotesCollection = new ObservableCollection<NoteModel>();
            
        }
    }
}
