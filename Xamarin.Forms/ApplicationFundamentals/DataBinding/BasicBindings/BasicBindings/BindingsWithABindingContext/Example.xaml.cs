using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBindings.BindingsWithABindingContext
{
    public partial class Example : ContentPage
    {
        public Example()
        {
            InitializeComponent();

            // sliderB
            labelB.BindingContext = sliderB;
            labelB.SetBinding(RotationProperty, "Value");
        }

        void sliderA_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            labelA.Rotation = slider.Value;
        }
    }
}
