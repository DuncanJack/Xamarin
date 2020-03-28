using System;
using System.Diagnostics;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace TheTranslateTransform
{
    public class HendecagramAnimationPage : ContentPage
    {
        const double cycleTime = 5000;

        SKCanvasView canvasView;
        Stopwatch stopwatch = new Stopwatch();
        bool pageIsActive;
        float angle;

        public HendecagramAnimationPage()
        {
            canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            pageIsActive = true;
            stopwatch.Start();

            Device.StartTimer(TimeSpan.FromMilliseconds(33), () =>
            {
                double t = stopwatch.Elapsed.TotalMilliseconds % cycleTime / cycleTime;
                angle = (float)(360 * t);
                canvasView.InvalidateSurface();

                if(!pageIsActive)
                {
                    stopwatch.Stop();
                }

                return pageIsActive;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            pageIsActive = false;
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();
            canvas.Translate(info.Width/2, info.Height/2);
            float radius = (float)Math.Min(info.Width, info.Height) / 2 - 100;

            using (SKPaint paint = new SKPaint())
            {
                paint.Style = SKPaintStyle.Fill;
                paint.Color = SKColor.FromHsl(angle, 100, 50);

                float x = radius * (float)Math.Sin(Math.PI * angle / 180);
                float y = -radius * (float)Math.Cos(Math.PI * angle / 180);
                canvas.Translate(x, y);
                canvas.DrawPath(HendecagramArrayPage.HendecagramPath, paint);
            }
        }
    }
}




























