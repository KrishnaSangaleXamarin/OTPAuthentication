﻿using OTPAuthentication.ViewModels.OtpAuthentication;
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
    public partial class MobileNumber : ContentPage
    {
        public MobileNumber()
        {
            InitializeComponent();
            this.BindingContext = new MobileNumberViewModel();
            Preferences.Set("Number", mobileNumber.Text);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(mobileNumber.Text.Length == 10)
            {
                checkImage.IsVisible = true;
            }
            else
            {
                checkImage.IsVisible = false;
            }
        }

    }
}