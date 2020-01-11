using System;
using System.Collections.Generic;

using SkiaSharp;
using SkiaSharp.Views.Forms;

using Xamarin.Forms;

namespace DrawingBasics
{
    public partial class DrawingASimpleCircle : ContentPage
    {
        public DrawingASimpleCircle()
        {
            InitializeComponent();

            Title = "Drawing a Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;

            Content = canvasView;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint();
            paint.IsAntialias = true;

            // Stroke.
            paint.Style = SKPaintStyle.Stroke;
            paint.Color = Color.Red.ToSKColor();
            paint.StrokeWidth = 25;
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);

            // Fill.
            paint.Style = SKPaintStyle.Fill;
            paint.Color = Color.Blue.ToSKColor();
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);

        }

    }
}
