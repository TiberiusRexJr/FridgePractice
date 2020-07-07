using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xmal_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command DismissPageCommand { get; }

        public string noteText;
        public DetailPage(string note)
        {
            InitializeComponent();
            DismissPageCommand = new Command(async()=>
            {
                await Application.Current.MainPage.Navigation.PopAsync();
                NoteText = note;
            });


        }
        public string NoteText
        {
            get => NoteText;
            set
            {
                noteText = value;
            }
        }



    }
}