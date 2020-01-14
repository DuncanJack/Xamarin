using System;
using System.Collections.Generic;

using SkiaSharp;
using SkiaSharp.Views.Forms;

using Xamarin.Forms;

namespace IntegratingWithXamarinForms
{
    public partial class ColorExplore : ContentPage
    {
        public ColorExplore()
        {
            InitializeComponent();

            hueSlider.Value = 0;
            saturationSlider.Value = 100;
            lightnessSlider.Value = 50;
            valueSlider.Value = 100;
        }

        void OnSlider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            hslCanvasView.InvalidateSurface();
            hsvCanvasView.InvalidateSurface();
        }

        void OnHslCanvasView_PaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKColor color = SKColor.FromHsl(
                (float)hueSlider.Value,
                (float)saturationSlider.Value,
                (float)lightnessSlider.Value
            );

            e.Surface.Canvas.Clear(color);

            hslLabel.Text = string.Format(" RGB = {0:X2}-{1:X2}-{2:X2} ",
                color.Red, color.Green, color.Blue);
        }

        void OnHsvCanvasView_PaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKColor color = SKColor.FromHsv(
                (float)hueSlider.Value,
                (float)saturationSlider.Value,
                (float)valueSlider.Value
            );

            e.Surface.Canvas.Clear(color);

            hsvLabel.Text = string.Format(" RGB = {0:X2}-{1:X2}-{2:X2} ",
                color.Red, color.Green, color.Blue);
        }
    }
}
