using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

using namespace NAV_XAML_PRACTICE_2.ViewModels
{
    public class AboutViewModel: BaseViewModel
    {
        public ICommand CommandOpenBrowser {get;}
        public AboutViewModel()
        {
            Title="Learn more";
            CommandOpenBrowser=new Command(async()=>await Browswer.Open("http://www.Xamarin.com"));

        }
    }
}