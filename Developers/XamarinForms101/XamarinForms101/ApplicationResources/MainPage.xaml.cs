using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms101.ApplicationResources
{
    public partial class MainPage : ContentPage
    {
        public int PageResourceCount => Resources.Count;
        public int AppResourceCount => App.Current.Resources.Count;

        public MainPage()
        {
            InitializeComponent();

            label1.Text = $"PageResourceCount: {PageResourceCount}";
            label2.Text = $"AppResourceCount: {AppResourceCount}";
        }
    }
}
