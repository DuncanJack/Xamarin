using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace LinesAndStrokeCaps
{
    public partial class MultipleLinesPage : ContentPage
    {
        public MultipleLinesPage()
        {
            InitializeComponent();
        }

        void OnPickerSelectedIndexChanged(Object sender, EventArgs e)
        {
            if (canvasView != null)
            {
                canvasView.InvalidateSurface();
            }
        }

        void OnCanvasViewPaintSurface(Object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            // Create an array of points scattered through the page
            SKPoint[] points = new SKPoint[10];

            for (int i = 0; i < 2; i++)
            {
                float x = (0.1f + 0.8f * i) * info.Width;

                for (int j = 0; j < 5; j++)
                {
                    float y = (0.1f + 0.2f * j) * info.Height;
                    points[2 * j + i] = new SKPoint(x, y);
                }
            }

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.DarkOrchid,
                StrokeWidth = 50,
                StrokeCap = (SKStrokeCap)strokeCapPicker.SelectedItem
            };

            // Render the points by calling DrawPoints
            SKPointMode pointMode = (SKPointMode)pointModePicker.SelectedItem;
            canvas.DrawPoints(pointMode, points, paint);
        }
    }
}
