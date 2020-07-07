using System.ComponentModel;
using Xamarin.Forms;
using DummyPlug.ViewModels;

namespace DummyPlug.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}