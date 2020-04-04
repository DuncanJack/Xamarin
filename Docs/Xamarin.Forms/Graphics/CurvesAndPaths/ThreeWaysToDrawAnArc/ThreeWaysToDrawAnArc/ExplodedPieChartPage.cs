using System;
using System.Linq;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace ThreeWaysToDrawAnArc
{
    public class ExplodedPieChartPage : ContentPage
    {
        class ChartData
        {
            public ChartData(int value, SKColor color)
            {
                Value = value;
                Color = color;
            }

            public int Value { get; private set; }
            public SKColor Color { get; private set; }
        }

        ChartData[] chartData =
        {
            new ChartData(45, SKColors.Red),
            new ChartData(13, SKColors.Green),
            new ChartData(27, SKColors.Blue),
            new ChartData(19, SKColors.Magenta),
            new ChartData(40, SKColors.Cyan),
            new ChartData(22, SKColors.Brown),
            new ChartData(29, SKColors.Gray)
        };

        public ExplodedPieChartPage()
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

            int totalValues = chartData.Sum(x => x.Value);

            SKPoint center = new SKPoint(info.Width / 2, info.Height / 2);
            float explodedOffset = 50;
            float radius = Math.Min(info.Width / 2, info.Height / 2) - 2 * explodedOffset;
            SKRect rect = new SKRect(center.X - radius, center.Y - radius, center.X + radius, center.Y + radius);

            float startAngle = 0;

            foreach (ChartData item in chartData)
            {
                float sweepAngle = 360f * item.Value / totalValues;

                using (SKPath path = new SKPath())
                using (SKPaint fillPaint = new SKPaint())
                using (SKPaint outlinePaint = new SKPaint())
                {
                    path.MoveTo(center);
                    path.ArcTo(rect, startAngle, sweepAngle, false);
                    path.Close();

                    fillPaint.IsAntialias = true;
                    fillPaint.Style = SKPaintStyle.Fill;
                    fillPaint.Color = item.Color;

                    outlinePaint.IsAntialias = true;
                    outlinePaint.Style = SKPaintStyle.Stroke;
                    outlinePaint.StrokeWidth = 5;
                    outlinePaint.Color = SKColors.Black;

                    // Calculate "explode" transform
                    float angle = startAngle + 0.5f * sweepAngle;
                    float x = explodedOffset * (float)Math.Cos(Math.PI * angle / 180);
                    float y = explodedOffset * (float)Math.Sin(Math.PI * angle / 180);

                    canvas.Save();
                    canvas.Translate(x, y);

                    // Fill and stroke the path
                    canvas.DrawPath(path, fillPaint);
                    canvas.DrawPath(path, outlinePaint);
                    canvas.Restore();
                }

                startAngle += sweepAngle;
            }
        }
    }
}

