using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms101.ControlReferenceBinding
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            MyCommand = new Command<string>((s) =>
            {
                Console.WriteLine(s);
            });
        }

        public ICommand MyCommand { get; set; }
    }
}