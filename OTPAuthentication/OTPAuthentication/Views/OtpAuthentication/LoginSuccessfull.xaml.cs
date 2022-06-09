using OTPAuthentication.ViewModels.OtpAuthentication;
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
    public partial class LoginSuccessfull : ContentPage
    {
        public LoginSuccessfull()
        {
            InitializeComponent();
            this.BindingContext = new LoginSuccessfullViewModel();
            NavigateToNextPage();
        }


        public async void NavigateToNextPage()
        {
            await Task.Delay(2000);
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
            
        

    }
}