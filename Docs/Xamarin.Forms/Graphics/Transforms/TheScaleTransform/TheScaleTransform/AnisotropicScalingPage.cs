using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheScaleTransform
{
    public class AnisotropicScalingPage : ContentPage
    {
        public static readonly SKPath Path;

        static AnisotropicScalingPage()
        {
            // Create 11-pointed star
            Path = new SKPath();
            for (int i = 0; i < 11; i++)
            {
                double angle = 5 * i * 2 * Math.PI / 11;
                SKPoint pt = new SKPoint(100 * (float)Math.Sin(angle), -100 * (float)Math.Cos(angle));

                if (i == 0) Path.MoveTo(pt);
                else Path.LineTo(pt);
            }
            Path.Close();
        }

        public AnisotropicScalingPage()
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

            SKRect pathBounds = Path.Bounds;

            using (SKPaint fillPaint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = SKColors.Pink
            })
            using (SKPaint strokPaint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue,
                StrokeWidth = 3,
                StrokeJoin = SKStrokeJoin.Round
            })
            {
                // Take account of the stroke width.
                pathBounds.Inflate(strokPaint.StrokeWidth / 2, strokPaint.StrokeWidth / 2);

                canvas.Scale(info.Width / pathBounds.Width, info.Height / pathBounds.Height);

                canvas.Translate(-pathBounds.Left, -pathBounds.Top);

                canvas.DrawPath(Path, fillPaint);
                canvas.DrawPath(Path, strokPaint);
            }
        }
    }
}

