using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppClass
{
    public partial class App : Application
    {
        public App()
        {
            Console.WriteLine("App");

            InitializeComponent();

            MainPage = new MainPage { Title = "AppClass" };
            App.Current.Properties["Constructed"] = DateTime.Now.ToLongTimeString();
        }

        protected override void OnStart()
        {
            Console.WriteLine($"App.OnStart, Constructed: {App.Current.Properties["Constructed"]}");
        }

        protected override void OnSleep()
        {
            Console.WriteLine($"App.OnSleep, Constructed: {App.Current.Properties["Constructed"]}");
        }

        protected override void OnResume()
        {
            Console.WriteLine($"App.OnResume, Constructed: {App.Current.Properties["Constructed"]}");
        }
    }
}
