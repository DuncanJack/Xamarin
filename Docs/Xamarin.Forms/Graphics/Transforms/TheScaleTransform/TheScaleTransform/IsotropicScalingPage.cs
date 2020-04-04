using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheScaleTransform
{
    public class IsotropicScalingPage : ContentPage
    {
        public IsotropicScalingPage()
        {
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas canvas = e.Surface.Canvas;

            canvas.Clear();

            SKPath path = AnisotropicScalingPage.Path;
            SKRect pathBounds = path.Bounds;

            using (SKPaint fillPaint = new SKPaint())
            {
                fillPaint.IsAntialias = true;
                fillPaint.Style = SKPaintStyle.Fill;

                float scale = Math.Min(info.Width / pathBounds.Width, info.Height/pathBounds.Height);

                for (int i = 0; i <= 10; i++)
                {
                    fillPaint.Color = new SKColor((byte)(255 * (10 - i) / 10), 0, (byte)(255 * i / 10));

                    canvas.Save();
                    canvas.Translate(info.Width / 2, info.Height / 2);
                    canvas.Scale(scale);
                    canvas.Translate(-pathBounds.MidX, -pathBounds.MidY);
                    canvas.DrawPath(path, fillPaint);
                    canvas.Restore();

                    scale *= 0.9f;
                }
            }
        }
    }
}