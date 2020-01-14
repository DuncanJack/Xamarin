using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PopupsTutorial
{
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        async void OnDisplayActionSheetButtonClicked(System.Object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("Send to?","Cancel",null,"Email","Twitter","Facebook");
            Console.WriteLine("Action: " + action);
        }
    }
}
