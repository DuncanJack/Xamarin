using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Drawing
{
    public class LinePage : ContentPage
    {
        public LinePage()
        {
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += CanvasView_PaintSurface;
            Content = canvasView;
        }

        private void CanvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                StrokeWidth = 10,
                Color = SKColors.Green
            };

            canvas.DrawLine(20, 20, 50, 50, paint);
        }
    }
}

