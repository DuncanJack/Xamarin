using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicBindings
{
    public partial class WithABindingContext : ContentPage
    {
        public WithABindingContext()
        {
            InitializeComponent();

            // sliderB
            labelB.BindingContext = sliderB;
            labelB.SetBinding(RotationProperty, "Value");
        }

        void OnSliderA_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            labelA.Rotation = slider.Value;
        }
    }
}
