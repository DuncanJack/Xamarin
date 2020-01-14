using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EntryTutorial
{
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        void OnEntryTextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEntryCompleted(System.Object sender, System.EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }
}
