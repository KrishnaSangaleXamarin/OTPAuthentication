﻿using OTPAuthentication.Models;
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
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();
            MyList.ItemsSource = connection.Table<Notification>().ToList();
        }
    }
}