using OTPAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class NotificationPageViewModel : BaseViewModel
    {
        public ObservableCollection<Notification> Notifications { get; set; }
        public NotificationPageViewModel()
        {
            Notifications = new ObservableCollection<Notification>();
            Notifications.Add(new Notification
            {
                Image = "https://cdn2.iconfinder.com/data/icons/ios-7-icons/50/sale-256.png",
                Time = DateTime.Now,
                Message = "this is notification",
                Title = "Notification One"
            });
            Notifications.Add(new Notification
            {
                Image = "https://cdn4.iconfinder.com/data/icons/picons-social/57/38-instagram-2-256.png",
                Time = DateTime.Now,
                Message = "this is notification",
                Title = "Notification Two"
            });
            Notifications.Add(new Notification
            {
                Image = "https://cdn0.iconfinder.com/data/icons/education-340/100/Tilda_Icons_1ed_mail-256.png",
                Time = DateTime.Now,
                Message = "this is notification",
                Title = "Notification Three"
            });
            Notifications.Add(new Notification
            {
                Image = "https://cdn4.iconfinder.com/data/icons/popular-social-media-1/512/youtube-256.png",
                Time = DateTime.Now,
                Message = "this is notification",
                Title = "Notification Four"
            });
        }
    }
}
