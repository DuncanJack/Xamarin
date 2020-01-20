using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLifecycle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyTabbedPage();

            PageAppearing += (object sender, Page e) => Console.WriteLine($"PageAppearing: {e.Title}");
            PageDisappearing += (object sender, Page e) => Console.WriteLine($"PageDisppearing: {e.Title}");

            ModalPushing += (object sender, ModalPushingEventArgs e) => Console.WriteLine($"ModalPushing, triggered by: {e.Modal.Title}");
            ModalPushed += (object sender, ModalPushedEventArgs e) => Console.WriteLine($"ModalPushed, triggered by: {e.Modal.Title}");

            ModalPopping += (object sender, ModalPoppingEventArgs e) => Console.WriteLine($"ModalPopping, triggered by: {e.Modal.Title}");
            ModalPopped += (object sender, ModalPoppedEventArgs e) => Console.WriteLine($"ModalPopped, triggered by: {e.Modal.Title}");
        }

        private void App_ModalPopped(object sender, ModalPoppedEventArgs e)
        {
            throw new NotImplementedException();
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
