using System;

using Xamarin.Forms;

namespace ErrorRoseAnalysis
{
    public class MyNewPage : ContentPage
    {
        public MyNewPage()
        {
            Content = MyGrid();
        }

        private Grid MyGrid()
        {
            Grid grid = new Grid();

            grid.RowDefinitions = new RowDefinitionCollection
            {
                new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) },
                new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) }
            };

            grid.ColumnDefinitions = new ColumnDefinitionCollection
            {
                new ColumnDefinition{ Width=new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition{ Width=new GridLength(1, GridUnitType.Star) }
            };


            BoxView a = new BoxView { BackgroundColor = Color.Cyan};
            BoxView b = new BoxView { BackgroundColor = Color.Magenta };
            BoxView c = new BoxView { BackgroundColor = Color.Yellow };
            BoxView d = new BoxView { BackgroundColor = Color.Black };

            grid.Children.Add(a, 0, 0);
            grid.Children.Add(b, 0, 1);
            grid.Children.Add(c, 1, 0);
            grid.Children.Add(d, 1, 1);

            return grid;
        }

    }
}

