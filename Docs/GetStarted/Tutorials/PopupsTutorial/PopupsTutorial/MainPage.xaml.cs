using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsTutorial
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

        async void ToolbarItemA_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new A());
        }

        async void ToolbarItemB_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new B());
        }

        async void OnDisplayAlertButtonClicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }

        async void OnDisplayAlertQuestionButtonClicked(System.Object sender, System.EventArgs e)
        {
            bool response = await DisplayAlert("Save?","Would you like to save?","Yes","No");
            Console.WriteLine("Save data: " + response);
        }
    }
}