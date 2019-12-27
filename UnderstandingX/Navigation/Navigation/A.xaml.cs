using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        async void NavigateToBButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new B { });
        }

        async void NavigateToBToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new B { });
        }
    }
}
