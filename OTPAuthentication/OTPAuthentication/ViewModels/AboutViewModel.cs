using OTPAuthentication.Views.OtpAuthentication;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(OpenAsync);
        }

        private void OpenAsync()
        {
            App.Current.MainPage.Navigation.PushAsync(new NotificationPage());
        }

        public Command OpenWebCommand { get; }
       
    }
}