using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
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

        async void ViewToViewBindingsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ViewToViewBindings());
        }

        async void BindingModeButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BindingMode());
        }

        async void BindingsAndCollectionsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BindingsAndCollections());
        }
    }
}
