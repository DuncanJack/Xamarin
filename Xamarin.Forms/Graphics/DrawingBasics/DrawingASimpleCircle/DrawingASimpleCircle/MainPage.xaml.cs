using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace DrawingASimpleCircle
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Drawing a Simple Circle";

            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;

            Content = canvasView;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint();
            paint.IsAntialias = true;

            // Stroke.
            paint.Style = SKPaintStyle.Stroke;
            paint.Color = Color.Red.ToSKColor();
            paint.StrokeWidth = 25;
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);

            // Fill.
            paint.Style = SKPaintStyle.Fill;
            paint.Color = Color.Blue.ToSKColor();
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);

        }
    }
}
