using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Drawing
{
    public partial class MyCirclePage : ContentPage
    {
        public MyCirclePage()
        {
            InitializeComponent();
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };

            float d = Math.Min(info.Height, info.Width) / 4f;

            paint.Color = SKColors.Red;
            canvas.DrawCircle(d, d, d, paint);

            paint.Color = SKColors.Green;
            canvas.DrawCircle(d, 3 * d, d, paint);

            paint.Color = SKColors.Blue;
            canvas.DrawCircle(3 * d, d, d, paint);

            paint.Color = SKColors.Yellow;
            canvas.DrawCircle(3 * d, 3 * d, d, paint);
        }
    }
}
