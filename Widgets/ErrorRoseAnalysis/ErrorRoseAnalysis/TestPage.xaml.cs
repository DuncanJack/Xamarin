using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ErrorRoseAnalysis
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), Animate);
        }

        private SKColor _color = SKColors.Green;

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.Red);

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = _color
            };

            SKPoint point = new SKPoint
            {
                X = info.Width/2,
                Y = info.Height/2
            };

            canvas.DrawCircle(point, 50f, paint);
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _color = SKColors.Red;
            canvasView.InvalidateSurface();
        }

        bool Animate()
        {
            _color = _color == SKColors.Green ? SKColors.Red : SKColors.Green;
            canvasView.InvalidateSurface();
            return true;
        }
    }
}
