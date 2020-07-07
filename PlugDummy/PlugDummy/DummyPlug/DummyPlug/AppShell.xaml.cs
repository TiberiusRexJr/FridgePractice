﻿using System;
using System.Collections.Generic;
using DummyPlug.ViewModels;
using DummyPlug.Views;
using Xamarin.Forms;

namespace DummyPlug
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
