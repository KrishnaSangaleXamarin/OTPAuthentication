using OTPAuthentication.Models;
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
            set { title = value; }
        }

        public Command AddNotification { get; set; }
        public ObservableCollection<Notification> Notifications;
        public NotificationAddViewModel()
        {
            AddNotification = new Command(AddItems);
        }

        private void AddItems(object obj)
        {
           
        }
    }
}
