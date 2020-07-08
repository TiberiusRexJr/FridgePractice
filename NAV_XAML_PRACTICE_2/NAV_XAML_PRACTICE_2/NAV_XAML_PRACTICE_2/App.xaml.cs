using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NAV_XAML_PRACTICE_2.Services;
using NAV_XAML_PRACTICE_2.Views;

namespace NAV_XAML_PRACTICE_2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
