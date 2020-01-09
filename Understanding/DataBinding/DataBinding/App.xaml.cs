using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage { BindingContext = new Place { Name="Place A",Population=100} };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
