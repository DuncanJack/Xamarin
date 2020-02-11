using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace PolylinesAndParametricEquations
{
    public class EllipsePage : ContentPage
    {
        public EllipsePage()
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

            canvas.Clear(SKColors.Red);

            using (SKPath path = new SKPath())
            {
                for (float angle = 0; angle < 270; angle += 1)
                {
                    double radians = Math.PI * angle / 180;
                    float x = info.Width / 2 + (info.Width / 2) * (float)Math.Cos(radians);
                    float y = info.Height / 2 + (info.Height / 2) * (float)Math.Sin(radians);

                    if (angle == 0)
                    {
                        path.MoveTo(x, y);
                    }
                    else
                    {
                        path.LineTo(x, y);
                    }
                }

                path.Close();

                SKPaint paint = new SKPaint
                {
                    IsAntialias = true,
                    Color = SKColors.Blue,
                    StrokeWidth = 2
                };

                canvas.DrawPath(path, paint);
            }
        }
    }
}