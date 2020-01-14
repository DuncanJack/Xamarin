using System;
using System.Collections.Generic;
using System.Linq;
using ListViewTutorial.Models;
using Xamarin.Forms;

namespace ListViewTutorial
{
    public partial class A : ContentPage
    {
        public IEnumerable<Monkey> Monkeys
        {
            get
            {
                return Zoo.Monkeys.OrderBy(x => x.Name);
            }
        }

        public A()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
