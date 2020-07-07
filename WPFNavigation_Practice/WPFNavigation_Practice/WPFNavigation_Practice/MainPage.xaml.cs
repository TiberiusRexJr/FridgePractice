using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WPFNavigation_Practice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void EntryUserEmail_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private async void  Login(object sender, EventArgs e)
        {
            var dash = new NavigationPage(new Dashboard());

            await Navigation.PushAsync(dash);
        }
    }
}
