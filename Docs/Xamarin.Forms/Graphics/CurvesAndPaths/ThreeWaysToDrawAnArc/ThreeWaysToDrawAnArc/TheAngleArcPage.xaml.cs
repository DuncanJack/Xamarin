using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SkiaSharp.Views.Forms;
using SkiaSharp;

namespace ThreeWaysToDrawAnArc
{
    public partial class TheAngleArcPage : ContentPage
    {
        SKPaint outlinePaint = new SKPaint
        {
            IsAntialias = true,
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 3,
            Color = SKColors.Black
        };

        SKPaint arcPaint = new SKPaint
        {
            IsAntialias = true,
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 15,
            Color = SKColors.Red
        };

        public TheAngleArcPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            canvasView?.InvalidateSurface();
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas canvas = e.Surface.Canvas;

            canvas.Clear();

            SKRect rect = new SKRect(100, 100, info.Width - 100, info.Height - 100);
            float startAngle = (float)startAngleSlider.Value;
            float sweepAngle = (float)sweepAngleSlider.Value;

            canvas.DrawRect(rect, outlinePaint);
            canvas.DrawOval(rect, outlinePaint);

            using (SKPath path = new SKPath())
            {
                path.AddArc(rect, startAngle, sweepAngle);
                canvas.DrawPath(path, arcPaint);
            }
        }
    }
}
