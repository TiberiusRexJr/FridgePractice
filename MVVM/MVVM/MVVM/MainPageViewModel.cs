using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MVVM
{
    public class MainPageViewModel : ContentPage
    {
        public MainPageViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}