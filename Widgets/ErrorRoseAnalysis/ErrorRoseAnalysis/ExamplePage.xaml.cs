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

            if(slider.Value < 5)
            {
                canvas.Clear(SKColors.Red);
            }
            else
            {
                canvas.Clear(SKColors.Blue);
            }

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
            Console.WriteLine($"OldValue: {e.OldValue}, NewValue: {e.NewValue}");


            double value = Math.Round(e.NewValue);

            label.Text = value.ToString();

            slider.Value = value;

            Console.WriteLine(value);

            canvasView.InvalidateSurface();
        }
    }
}
