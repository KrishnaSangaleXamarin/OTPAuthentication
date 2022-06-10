using OTPAuthentication.ViewModels;
using OTPAuthentication.Views.OtpAuthentication;
using System;
using System.ComponentModel;
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
    }
}