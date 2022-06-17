using OTPAuthentication.Views.OtpAuthentication;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await App.Current.MainPage.Navigation.PushAsync(new MobileNumber());
            
        }
    }
}
