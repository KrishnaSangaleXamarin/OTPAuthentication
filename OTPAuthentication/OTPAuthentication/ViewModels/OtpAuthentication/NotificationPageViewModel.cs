using OTPAuthentication.Models;
using OTPAuthentication.Views.OtpAuthentication;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class NotificationPageViewModel : BaseViewModel
    {
        public Command GoToNotificationAddPage { get; set; }
        public Command LoadAllItems { get; set; }
        public IEnumerable<Notification> Notifications { get; set; }
        public NotificationPageViewModel()
        {
            GoToNotificationAddPage = new Command(NavigateToNotificationAddPage);
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();
            Notifications = connection.Table<Notification>().ToList().OrderByDescending(f => f.Title).Take(6);
            LoadAllItems = new Command(AllItems);
        }

        private void AllItems(object obj)
        {
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();
            Notifications = connection.Table<Notification>().ToList();
        }

        private void NavigateToNotificationAddPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new NotificationAdd());
        }
    }
}
