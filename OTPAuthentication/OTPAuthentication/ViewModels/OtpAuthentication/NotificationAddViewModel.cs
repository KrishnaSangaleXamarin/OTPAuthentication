using OTPAuthentication.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class NotificationAddViewModel : BaseViewModel
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public Command AddNotification { get; set; }
        public NotificationAddViewModel()
        {
            AddNotification = new Command(AddItems);
        }

        private void AddItems(object obj)
        {
            var person = new Notification()
            {
                Title = Title,
                Message = Message
            };

            //Connection with database
            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();


            int rows = connection.Insert(person);
            connection.Close();

            if (rows > 0)
            {
                App.Current.MainPage.DisplayAlert("Success", "Notification Added Successfully", "Ok");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Failure", "Filed to Add Notification", "Ok");
            }

            // return to homepage
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
