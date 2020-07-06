using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaml_1_practice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ObservableCollection<string> notes;
        public Command SaveCommand;
       public  Command DeleteCommand;
        string theNote;
        public Page1()
        {
            InitializeComponent();
            SaveCommand = new Command(() => { notes.Add(theNote); theNote = string.Empty; });
            DeleteCommand = new Command(() => { });
        }
    }
}