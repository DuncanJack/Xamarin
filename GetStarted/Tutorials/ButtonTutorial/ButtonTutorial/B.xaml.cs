using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ButtonTutorial
{
    public partial class B : ContentPage
    {
        public B()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine($"Time: {DateTime.Now.ToLongTimeString()}");
        }
    }
}
