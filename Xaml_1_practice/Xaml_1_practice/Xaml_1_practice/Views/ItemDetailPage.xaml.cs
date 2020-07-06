using System.ComponentModel;
using Xamarin.Forms;
using Xaml_1_practice.ViewModels;

namespace Xaml_1_practice.Views
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