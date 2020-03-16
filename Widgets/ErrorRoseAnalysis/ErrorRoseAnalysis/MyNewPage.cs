using System;

using Xamarin.Forms;

namespace ErrorRoseAnalysis
{
    public class MyNewPage : ContentPage
    {
        public MyNewPage()
        {
            Content = new StackLayout
            {
                Children = {
                    MyGrid()
                }
            };
        }

        private Grid MyGrid()
        {
            Grid grid = new Grid {BackgroundColor = Color.Red, ColumnSpacing = 0, RowSpacing = 20};

            grid.ColumnDefinitions = new ColumnDefinitionCollection
            {
                new ColumnDefinition{ Width=new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition{ Width=new GridLength(1, GridUnitType.Star) }
            };

            grid.RowDefinitions = new RowDefinitionCollection
            {
                new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) },
                new RowDefinition{ Height=new GridLength(1, GridUnitType.Star) }
            };

            //Label a = new Label { Text = "A", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
            //Label b = new Label { Text = "B", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
            //Label c = new Label { Text = "C", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
            //Label d = new Label { Text = "D", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand};

            BoxView a = new BoxView { BackgroundColor = Color.Cyan, HorizontalOptions = LayoutOptions.FillAndExpand};
            BoxView b = new BoxView { BackgroundColor = Color.Magenta, HorizontalOptions = LayoutOptions.FillAndExpand };
            BoxView c = new BoxView { BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.FillAndExpand };
            BoxView d = new BoxView { BackgroundColor = Color.Black, HorizontalOptions = LayoutOptions.FillAndExpand };

            grid.Children.Add(a, 0, 0);
            grid.Children.Add(b, 0, 1);
            grid.Children.Add(c, 1, 0);
            grid.Children.Add(d, 1, 1);

            //var grid = new Grid();

            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //var topLeft = new Label { Text = "Top Left" };
            //var topRight = new Label { Text = "Top Right" };
            //var bottomLeft = new Label { Text = "Bottom Left" };
            //var bottomRight = new Label { Text = "Bottom Right" };

            //grid.Children.Add(topLeft, 0, 0);
            //grid.Children.Add(topRight, 1, 0);
            //grid.Children.Add(bottomLeft, 0, 1);
            //grid.Children.Add(bottomRight, 1, 1);

            return grid;
        }

    }
}

