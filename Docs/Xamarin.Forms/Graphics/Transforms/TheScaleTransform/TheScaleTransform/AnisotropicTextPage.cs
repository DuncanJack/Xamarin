using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheScaleTransform
{
    public class AnisotropicTextPage : ContentPage
    {
        public AnisotropicTextPage()
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

            using (SKPaint textPaint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue,
                StrokeWidth = 0.1f,
                StrokeJoin = SKStrokeJoin.Round
            })
            {
                SKRect textBounds = new SKRect();
                textPaint.MeasureText("HELLO", ref textBounds);
                textBounds.Inflate(textPaint.StrokeWidth / 2, textPaint.StrokeWidth / 2);

                canvas.Scale(info.Width/textBounds.Width, info.Height/textBounds.Height);
                canvas.Translate(-textBounds.Left, -textBounds.Top);
                canvas.DrawText("HELLO", 0, 0, textPaint);
            }
        }
    }
}

