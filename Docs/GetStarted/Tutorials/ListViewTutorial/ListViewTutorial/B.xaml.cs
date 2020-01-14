using System;
using System.Collections.Generic;
using System.Linq;
using ListViewTutorial.Models;
using Xamarin.Forms;

namespace ListViewTutorial
{
    public partial class B : ContentPage
    {
        public IEnumerable<Monkey> Monkeys
        {
            get
            {
                return Zoo.Monkeys.OrderBy(x => x.Name);
            }
        }

        public B()
        {
            InitializeComponent();

            BindingContext = this;
        }

        void OnListViewItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Monkey selectedItem = e.SelectedItem as Monkey;
        }

        void OnListViewItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Monkey tappedItem = e.Item as Monkey;
        }
    }
}
