using OTPAuthentication.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class LoginSuccessfullViewModel : BaseViewModel
    {
        public Command Navigate { get; set; }
        public LoginSuccessfullViewModel()
        {
            Navigate = new Command(NavigateToMobileNumberPage);
        }

        private async void NavigateToMobileNumberPage(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        public async void NavigateToNextPage()
        {
            await Task.Delay(2000);
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
