using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Drawing
{
    public partial class MyLinePage : ContentPage
    {
        public MyLinePage()
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
                Style = SKPaintStyle.Stroke,
                StrokeWidth = 10,
                StrokeCap = SKStrokeCap.Round,
                Color = SKColors.Black
            };

            canvas.DrawLine(info.Width * 0.0f, info.Height * 0.5f, info.Width * 1.0f, info.Height * 0.5f, paint);

            canvas.DrawLine(info.Width * 0.5F, info.Height * 0.0f, info.Width * 0.5f, info.Height * 1.0f, paint);

            canvas.DrawLine(info.Width * 0.4f, info.Height * 0.4f, info.Width * 0.6f, info.Height * 0.4f, paint);

            canvas.DrawLine(info.Width * 0.4f, info.Height * 0.6f, info.Width * 0.6f, info.Height * 0.6f, paint);
        }
    }
}
