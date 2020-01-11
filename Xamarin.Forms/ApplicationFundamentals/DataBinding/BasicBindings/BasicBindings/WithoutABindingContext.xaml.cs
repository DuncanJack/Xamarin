using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBindings
{
    public partial class WithoutABindingContext : ContentPage
    {
        public WithoutABindingContext()
        {
            InitializeComponent();

            labelB.SetBinding(ScaleProperty, new Binding("Value", source: sliderB));
        }
    }
}
