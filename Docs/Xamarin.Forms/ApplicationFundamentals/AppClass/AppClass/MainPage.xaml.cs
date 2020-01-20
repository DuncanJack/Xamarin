using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppClass
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

        void LogButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine($"LogButton_Clicked, Constructed: {App.Current.Properties["Constructed"]}");
        }
    }
}
