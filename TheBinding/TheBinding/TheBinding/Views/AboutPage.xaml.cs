using System;
using System.ComponentModel;
using TheBinding.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheBinding.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        AboutViewModel aboutView;
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = aboutView = new AboutViewModel();
        }
    }
}