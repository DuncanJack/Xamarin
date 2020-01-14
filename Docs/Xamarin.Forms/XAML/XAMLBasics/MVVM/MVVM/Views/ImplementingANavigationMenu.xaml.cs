using System;
using System.Collections.Generic;
using MVVM.ViewModels;
using Xamarin.Forms;

namespace MVVM.Views
{
    public partial class ImplementingANavigationMenu : ContentPage
    {
        public ImplementingANavigationMenu()
        {
            InitializeComponent();
        }

        async void OnListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;

            if(e.SelectedItem != null)
            {
                PageDataViewModel pageData = e.SelectedItem as PageDataViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}
