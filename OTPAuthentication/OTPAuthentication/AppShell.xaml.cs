using OTPAuthentication.ViewModels;
using OTPAuthentication.Views;
using OTPAuthentication.Views.OtpAuthentication;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OTPAuthentication
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        string mobileNumber;
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            this.BindingContext = this;

            mobileNumber = Preferences.Get("MobileNumber", string.Empty);
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
