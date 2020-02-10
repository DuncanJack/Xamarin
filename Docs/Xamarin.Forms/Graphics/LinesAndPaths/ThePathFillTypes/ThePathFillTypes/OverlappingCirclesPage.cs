using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ThePathFillTypes
{
    public class OverlappingCirclesPage : ContentPage
    {
        public OverlappingCirclesPage()
        {
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPoint center = new SKPoint(info.Width / 2, info.Height / 2);
            float radius = Math.Min(info.Width, info.Height) / 4;

            SKPath path = new SKPath
            {
                FillType = SKPathFillType.EvenOdd
            };

            path.AddCircle(center.X - radius / 2, center.Y - radius / 2, radius);
            path.AddCircle(center.X - radius / 2, center.Y + radius / 2, radius);
            path.AddCircle(center.X + radius / 2, center.Y - radius / 2, radius);
            path.AddCircle(center.X + radius / 2, center.Y + radius / 2, radius);

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Cyan
            };

            canvas.DrawPath(path, paint);

            paint.Style = SKPaintStyle.Stroke;
            paint.StrokeWidth = 10;
            paint.Color = SKColors.Magenta;

            canvas.DrawPath(path, paint);
        }
    }
}