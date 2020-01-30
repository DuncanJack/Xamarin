using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace BitmapBasics
{
    public class BasicBitmapsPage : ContentPage
    {
        SKCanvasView canvasView;
        SKBitmap webBitmap;
        SKBitmap resourceBitmap;
        SKBitmap libraryBitmap;

        HttpClient httpClient = new HttpClient();

        public BasicBitmapsPage()
        {
            canvasView = new SKCanvasView();
            canvasView.PaintSurface += OnCanvasViewPaintSurface;
            Content = canvasView;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await LoadWebBitmap();

            LoadResourceBitmap();
        }

        private async Task LoadWebBitmap()
        {
            string url = "https://developer.xamarin.com/demo/IMG_3256.JPG?width=480";

            try
            {
                using (Stream stream = await httpClient.GetStreamAsync(url))
                using (MemoryStream memStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);

                    webBitmap = SKBitmap.Decode(memStream);
                    canvasView.InvalidateSurface();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void LoadResourceBitmap()
        {
            string resourceId = "BitmapBasics.Media.xamarin.png";
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            try
            {
                using Stream stream = assembly.GetManifestResourceStream(resourceId);
                resourceBitmap = SKBitmap.Decode(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            if (webBitmap != null)
            {
                float x = (info.Width - webBitmap.Width) / 2;
                float y = (info.Height / 3 - webBitmap.Height) / 2;
                canvas.DrawBitmap(webBitmap, x, y);
            }

            if (resourceBitmap != null)
            {
                canvas.DrawBitmap(resourceBitmap,
                    new SKRect(0, info.Height / 3, info.Width, 2 * info.Height / 3));
            }
        }
    }
}

