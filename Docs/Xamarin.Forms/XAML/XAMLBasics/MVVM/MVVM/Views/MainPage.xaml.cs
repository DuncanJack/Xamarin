using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.Views
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

        async void ASimpleProgramWithoutAViewModelButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ASimpleProgramWithoutAViewModel());
        }

        async void ASimpleProgramWithAViewModelButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ASimpleProgramWithAViewModel());
        }

        async void InteractiveMVVMButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new InteractiveMVVM());
        }

        async void CommandingWithViewModelsButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CommandingWithViewModels());
        }

        async void ImplementingANavigationMenuButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ImplementingANavigationMenu());
        }
    }
}
