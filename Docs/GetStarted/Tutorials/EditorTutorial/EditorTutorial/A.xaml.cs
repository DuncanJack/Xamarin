using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EditorTutorial
{
    public partial class A : ContentPage
    {
        public A()
        {
            InitializeComponent();
        }

        void OnEditorTextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEditorCompleted(System.Object sender, System.EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }
    }
}
