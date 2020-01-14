using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetStarted
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Hello XAML Page!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HelloXamlPage());
            };

            Button button2 = new Button
            {
                Text = "XAML Plus Code Page!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button2.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new XamlPlusCodePage());
            };

            var stackLayout = new StackLayout();
            stackLayout.Children.Add(button);
            stackLayout.Children.Add(button2);

            Content = stackLayout;
        }
    }
}
