using OTPAuthentication.Services;
using OTPAuthentication.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPAuthentication
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new AppShell();


            //calls tha MainActivity.cs class for database location file
            DatabaseLocation = databaseLocation;
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
