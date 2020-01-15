using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms101.CommandParameters
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            CommandA = new Command(() =>
                Application.Current.MainPage.DisplayAlert("A", "a", "OK"));

            CommandB = new Command<string>((p) =>
                Application.Current.MainPage.DisplayAlert("B", p, "OK"));

            CommandC = new Command(() =>
                Application.Current.MainPage.DisplayAlert("C", "c", "OK"));

            CommandD = new Command(() =>
                Console.WriteLine("CommandD"));
        }

        public ICommand CommandA { get; set; }
        public ICommand CommandB { get; set; }
        public ICommand CommandC { get; set; }

        public ICommand CommandD { get; set; }
    }
}
