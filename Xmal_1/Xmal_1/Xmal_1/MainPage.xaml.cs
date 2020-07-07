using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xmal_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Command SaveNoteCommand;
        public Command EraseNoteCommand;
        public Command SelectedNoteChangedCommand { get; }
        public string selectedNote;

        public ObservableCollection<string> Notes;
        public MainPage()
        {
            InitializeComponent();
            Notes = new ObservableCollection<string>();
            SelectedNoteChangedCommand = new Command(async() =>
              {
                  var detailVM = new DetailPage(selectedNote);
                  var detailPage = new DetailPage();
                  detailPage.BindingContext = detailVM;
                  await Application.Current.MainPage.Navigation.PushAsync(detailPage);
              });
            SaveNoteCommand = new Command(() => { }, () => { });
            EraseNoteCommand = new Command(() => NoteText = string.Empty);
        }
        public string NoteText
        {

        }
    }
}
