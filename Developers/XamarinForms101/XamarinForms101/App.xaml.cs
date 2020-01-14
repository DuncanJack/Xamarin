using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms101.Services;
using XamarinForms101.Views;

namespace XamarinForms101
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
