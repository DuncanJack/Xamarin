using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalDatabaseTutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnAddToDatabaseButtonClicked(System.Object sender, System.EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePersonAsync(new Data.Person
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = string.Empty;
                ageEntry.Text = string.Empty;

                // Refresh the data in the ListView.
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
