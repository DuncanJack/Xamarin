using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Commands
{
    public class MyViewModel
    {
        public string Name { get { return "TEST"; } }

        public ICommand MyCommand { get; set; }

        public MyViewModel()
        {
            MyCommand = new Command(()=>
            {
                Console.WriteLine("MyCommand");
            });
        }
    }
}
