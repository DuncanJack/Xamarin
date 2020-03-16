using System;

using Xamarin.Forms;

namespace CoreLayouts.Grids
{
    public class MyGridPage2 : ContentPage
    {
        BoxView bv;

        public MyGridPage2()
        {
            Grid grid = new Grid
            {

                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition{ Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition{ Height = new GridLength(3, GridUnitType.Star)}
                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{ Width = new GridLength(3, GridUnitType.Star)}
                }
            };

            bv = new BoxView { BackgroundColor = Color.Red };


            Button button = new Button { Text = "Pink" };
            button.Clicked += OnButton_Clicked;

            grid.Children.Add(bv, 0, 0);
            grid.Children.Add(new BoxView { BackgroundColor = Color.Green }, 1, 0);
            grid.Children.Add(new BoxView { BackgroundColor = Color.Blue }, 0, 1);
            grid.Children.Add(button, 1, 1);

            Content = grid;
        }

        private void OnButton_Clicked(object sender, EventArgs e)
        {
            bv.BackgroundColor = Color.Pink;
        }
    }
}

