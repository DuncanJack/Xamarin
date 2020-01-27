using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace IntegratingTextAndGraphics
{
    public class ApproximatePage : ContentPage
    {
        public ApproximatePage()
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

            canvas.Clear(SKColors.AliceBlue);

            string text = "Hello World";

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Color = SKColors.DarkRed,
                Style = SKPaintStyle.Stroke,
                TextSize = 100f,
                TextAlign = SKTextAlign.Center
            };

            canvas.DrawText(text, info.Width / 2f, info.Height / 2f, paint);

        }
    }
}

