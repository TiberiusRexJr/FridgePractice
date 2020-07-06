using System;
using System.Collections.Generic;
using Xaml_1_practice.ViewModels;
using Xaml_1_practice.Views;
using Xamarin.Forms;

namespace Xaml_1_practice
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            this.BindingContext = new ShellViewModel();
        }
    }
}
