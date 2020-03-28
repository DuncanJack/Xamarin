using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheTranslateTransform
{
    public class TranslateTextEffectsPage : ContentPage
    {
        public TranslateTextEffectsPage()
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

            float textSize = 150;

            using (SKPaint textPaint = new SKPaint())
            {
                textPaint.IsAntialias = true;
                textPaint.Style = SKPaintStyle.Fill;
                textPaint.TextSize = textSize;
                textPaint.FakeBoldText = true;

                float x = 10;
                float y = textSize;

                // ABC
                canvas.Translate(50,50);
                textPaint.Color = SKColors.Black;
                canvas.DrawText("ABC", x, y, textPaint);
                canvas.Translate(-50, -50);
                textPaint.Color = SKColors.Red;
                canvas.DrawText("ABC", x, y, textPaint);

                y += 2 * textSize;

                // DEF
                canvas.Translate(50, 50);
                textPaint.Color = SKColors.Black;
                canvas.DrawText("DEF", x, y, textPaint);
                canvas.ResetMatrix();
                textPaint.Color = SKColors.Red;
                canvas.DrawText("DEF", x, y, textPaint);

                y += 2 * textSize;

                // GHI
                canvas.Save();
                canvas.Translate(50, 50);
                textPaint.Color = SKColors.Black;
                canvas.DrawText("GHI", x, y, textPaint);
                canvas.Restore();
                textPaint.Color = SKColors.Red;
                canvas.DrawText("GHI", x, y, textPaint);

            }
        }
    }
}

