using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms101.CommandParameters
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel VM => (MainPageViewModel)BindingContext;


        public MainPage()
        {
            InitializeComponent();

            VM.CommandD.Execute(null);
        }
    }
}
