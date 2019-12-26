using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class C : ContentPage
    {
        public C()
        {
            InitializeComponent();
        }

        async void NavigateToBButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void NavigateToBToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
