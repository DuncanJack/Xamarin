using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms101.DynamicResources
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Resources["MyColor"] = Color.Red;
        }
    }
}
