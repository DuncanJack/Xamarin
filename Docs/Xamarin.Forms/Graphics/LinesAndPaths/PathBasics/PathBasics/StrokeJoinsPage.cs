using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace PathBasics
{
    public class StrokeJoinsPage : ContentPage
    {
        public StrokeJoinsPage()
        {
            Title = "Stroke Joins";

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

            SKPaint textPaint = new SKPaint
            {
                IsAntialias = true,
                Color = SKColors.Black,
                TextSize = 75,
                TextAlign = SKTextAlign.Right
            };

            SKPaint thickLinePaint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Orange,
                StrokeWidth = 50
            };

            SKPaint thinLinePaint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Black,
                StrokeWidth = 2
            };

            float xText = info.Width - 100;
            float xLine1 = 100;
            float xLine2 = info.Width - xLine1;
            float y = 2 * textPaint.FontSpacing;
            string[] strStrokeJoins = { "Miter", "Round", "Bevel" };

            foreach(string strStrokeJoin in strStrokeJoins)
            {
                // Display text
                canvas.DrawText(strStrokeJoin, xText, y, textPaint);

                // Get stroke-join value
                SKStrokeJoin strokeJoin;
                Enum.TryParse(strStrokeJoin, out strokeJoin);

                // Create path
                SKPath path = new SKPath();
                path.MoveTo(xLine1, y - 80);
                path.LineTo(xLine1, y + 80);
                path.LineTo(xLine2, y + 80);

                // Display thick line
                thickLinePaint.StrokeJoin = strokeJoin;
                canvas.DrawPath(path, thickLinePaint);

                // Display thin line
                canvas.DrawPath(path, thinLinePaint);
                y += 3 * textPaint.FontSpacing;
            }
        }
    }
}