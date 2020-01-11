using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace IntegratingWithXamarinForms
{
    public partial class TapToggleFill : ContentPage
    {
        bool showFill = true;

        public TapToggleFill()
        {
            InitializeComponent();
        }

        void OnCanvasView_PaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint();
            paint.Style = SKPaintStyle.Stroke;
            paint.Color = Color.Red.ToSKColor();
            paint.StrokeWidth = 50;
            canvas.DrawCircle(info.Width/2, info.Height/2, 100, paint);

            if(showFill)
            {
                paint.Style = SKPaintStyle.Fill;
                paint.Color = SKColors.Blue;
                canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);
            }
        }

        void OnCanvasView_Tapped(System.Object sender, System.EventArgs e)
        {
            showFill ^= true;
            (sender as SKCanvasView).InvalidateSurface();
        }
    }
}
