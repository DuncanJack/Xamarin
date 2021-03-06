﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssentialSyntax
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

        async void PropertyElementsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PropertyElements());
        }

        async void AttachedPropertiesButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AttachedProperties());
        }

        async void AttachedProperties2Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AttachedProperties2());
        }

        async void ContentPropertiesButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ContentProperties());
        }

        async void PlatformDifferencesButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PlatformDifferences());
        }
    }
}
