using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SkiaSharp;
using Xamarin.Forms;

namespace Transparency
{
    public partial class BitmapDissolvePage : ContentPage
    {
        SKBitmap bitmap1;
        SKBitmap bitmap2;

        public BitmapDissolvePage()
        {
            InitializeComponent();

            // Load two bitmaps
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream("Transparency.Media.xamarin1.png"))
            {
                bitmap1 = SKBitmap.Decode(stream);
            }

            using (Stream stream = assembly.GetManifestResourceStream("Transparency.Media.xamarin2.png"))
            {
                bitmap2 = SKBitmap.Decode(stream);
            }

        }

        void OnCanvasViewPaintSurface(System.Object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            // Find rectangle to ftt bitmap
            float scale = Math.Min((float)info.Width / bitmap1.Width, (float)info.Height / bitmap1.Height);
            SKRect rect = SKRect.Create(scale * bitmap1.Width, scale * bitmap1.Height);
            float x = (info.Width - rect.Width) / 2;
            float y = (info.Height - rect.Height) / 2;
            rect.Offset(x, y);

            // Get progress value from slider
            float progress = (float)progressSlider.Value;

            // Diplay two bitmaps with transparency
            using (SKPaint paint = new SKPaint())
            {
                paint.Color = paint.Color.WithAlpha((byte)(0xFF * (1 - progress)));
                canvas.DrawBitmap(bitmap1, rect, paint);

                paint.Color = paint.Color.WithAlpha((byte)(0xFF * progress));
                canvas.DrawBitmap(bitmap2, rect, paint);
            }
        }

        void OnSliderValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            canvasView.InvalidateSurface();
        }
    }
}
