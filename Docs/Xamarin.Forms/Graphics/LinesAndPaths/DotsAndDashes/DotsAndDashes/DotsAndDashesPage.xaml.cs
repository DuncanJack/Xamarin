using System;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace DotsAndDashes
{
    public partial class DotsAndDashesPage : ContentPage
    {
        public DotsAndDashesPage()
        {
            InitializeComponent();
            SKCanvasView canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue,
                StrokeWidth = 10,
                StrokeCap = (SKStrokeCap)strokeCapPicker.SelectedItem,
                PathEffect = SKPathEffect.CreateDash(GetPickerArray(dashArrayPicker), 20)
            };

            SKPath path = new SKPath();
            path.MoveTo(0.2f * info.Width, 0.2f * info.Height);
            path.LineTo(0.8f * info.Width, 0.8f * info.Height);
            path.LineTo(0.2f * info.Width, 0.8f * info.Height);
            path.LineTo(0.8f * info.Width, 0.2f * info.Height);

            canvas.DrawPath(path, paint);
        }

        float[] GetPickerArray(Picker picker)
        {
            if (picker.SelectedIndex == -1)
            {
                return new float[0];
            }

            string str = (string)picker.SelectedItem;
            string[] strs = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            float[] array = new float[strs.Length];

            for(int i = 0; i < strs.Length; i++)
            {
                array[i] = Convert.ToSingle(strs[i]);
            }
            return array;
        }

        void OnPickerSelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            canvasView.InvalidateSurface();
        }
    }
}
