﻿using OTPAuthentication.Models;
using OTPAuthentication.ViewModels.OtpAuthentication;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPAuthentication.Views.OtpAuthentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationAdd : ContentPage
    {
        public NotificationAdd()
        {
            InitializeComponent();
        }
    }
}