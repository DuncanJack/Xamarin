using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Drawing
{
    public class CirclePage : ContentPage
    {
        float? _radius;

        public CirclePage()
        {
            Title = "CirclePage";
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            if (_radius == null)
                _radius = info.Width / 2;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Color = SKColors.Red,
                Style = SKPaintStyle.Fill
            };

            canvas.DrawCircle(info.Width / 2, info.Height / 2, _radius.Value, paint);
        }
    }
}

