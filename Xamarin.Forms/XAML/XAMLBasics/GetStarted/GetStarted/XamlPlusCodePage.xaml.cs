using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GetStarted
{
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();

            // When control returns from InitializeComponent,
            // the XAML file no longer plays any role in the class.
        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            // valueLabel is initialized in InitializeComponent.
            valueLabel.Text = e.NewValue.ToString("F3");

            // Or
            // valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                $"The button labelled {button.Text} has been clicked",
                "OK");
        }
    }
}
