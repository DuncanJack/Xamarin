using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppLifecycle
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        async void PushButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyPage());
        }

        async void PushModalButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MyPage { Title = "MyPage Modal" });
        }

        async void PopModalButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Title == "MyPage Modal")
                await Navigation.PopModalAsync();
        }

        async void XToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage { Title = "X" });
        }

        async void YToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage { Title = "Y" });
        }

        async void ZToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage { Title = "Z" });
        }
    }
}
