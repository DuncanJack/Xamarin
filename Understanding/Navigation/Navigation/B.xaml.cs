using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class B : ContentPage
    {
        public B()
        {
            InitializeComponent();
        }

        async void NavigateToAButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void NavigateToAToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void NavigateToCButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new C { });
        }

        async void NavigateToCToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new C { });
        }
    }
}
