using OTPAuthentication.Models;
using OTPAuthentication.ViewModels;
using OTPAuthentication.Views.OtpAuthentication;
using SQLite;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPAuthentication.Views
{
    public partial class AboutPage : TabbedPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.BindingContext = new AboutViewModel();
        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationPage());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();
            var count = connection.Table<Notification>().Count();
            notificationCount.Text = count.ToString();
        }
    }
}