using System;
using System.IO;
using LocalDatabaseTutorial.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabaseTutorial
{
    public partial class App : Application
    {
        static Database _database;

        public static Database Database
        {
            get
            {
                if(_database == null)
                {
                    var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var path = Path.Combine(localAppData,"people.db3");
                    _database = new Database(path);
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
