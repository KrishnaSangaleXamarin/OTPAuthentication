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

            CurrentPageChanged += MainPage_CurrentPageChanged;
            Title = CurrentPage.Title;
        }

        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            Title = CurrentPage.Title;
        }
    }
}