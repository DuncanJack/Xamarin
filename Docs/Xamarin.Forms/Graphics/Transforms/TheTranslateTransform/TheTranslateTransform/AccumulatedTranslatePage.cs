using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheTranslateTransform
{
    public class AccumulatedTranslatePage : ContentPage
    {
        public AccumulatedTranslatePage()
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

            using(SKPaint strokePaint = new SKPaint())
            {
                strokePaint.IsAntialias = true;
                strokePaint.Color = SKColors.Black;
                strokePaint.Style = SKPaintStyle.Stroke;
                strokePaint.StrokeWidth = 3;

                int rectangleCount = 20;
                SKRect rect = new SKRect(0,0,250,250);
                float xTranslate = (info.Width - rect.Width) / (rectangleCount - 1);
                float yTranslate = (info.Height - rect.Height) / (rectangleCount - 1);

                for(int i = 0; i < rectangleCount; i++)
                {
                    canvas.DrawRect(rect,strokePaint);
                    canvas.Translate(xTranslate,yTranslate);
                }
            }
        }
    }
}