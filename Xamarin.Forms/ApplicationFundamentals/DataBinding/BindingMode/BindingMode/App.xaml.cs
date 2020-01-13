using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingMode
{
    public partial class App : Application
    {
        public SampleSettingsViewModel Settings { get; set; }
        public App()
        {
            InitializeComponent();

            Settings = new SampleSettingsViewModel(Current.Properties);

            MainPage = new MyTabbedPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            Settings.SaveState(Current.Properties);
        }

        protected override void OnResume()
        {
        }
    }
}
