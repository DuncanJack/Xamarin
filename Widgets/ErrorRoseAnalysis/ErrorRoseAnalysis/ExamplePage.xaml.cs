using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ErrorRoseAnalysis
{
    public partial class ExamplePage : ContentPage
    {
        public ExamplePage()
        {
            InitializeComponent();
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = SKColors.PowderBlue
            };

            SKRect rect = new SKRect(50f, 50f, 100f, 100f);

            canvas.DrawRect(rect, paint);
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;

            slider.Value = 3f;

            Console.WriteLine(value);
        }
    }
}
