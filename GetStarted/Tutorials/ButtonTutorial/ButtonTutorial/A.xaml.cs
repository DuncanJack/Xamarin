using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ButtonTutorial
{
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            ((Button)sender).Text = "Click me again!";
        }
    }
}
