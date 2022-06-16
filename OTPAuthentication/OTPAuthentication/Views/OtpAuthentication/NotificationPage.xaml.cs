using OTPAuthentication.Models;
using OTPAuthentication.ViewModels.OtpAuthentication;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPAuthentication.Views.OtpAuthentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        Notification Notification;
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationAddView());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            //creating connection to database for get the data
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();

            //fetching data from database
            var posts = connection.Table<Notification>().ToList().OrderByDescending(f => f.Title).Take(6);
            MyList.ItemsSource = posts;

            var count = connection.Table<Notification>().Count();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //creating connection to database for get the data
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();

            //fetching data from database
            var posts = connection.Table<Notification>().ToList();
            MyList.ItemsSource = posts;
        }
    }
}