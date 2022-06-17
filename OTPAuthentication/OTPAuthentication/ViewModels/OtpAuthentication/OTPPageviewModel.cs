using OTPAuthentication.Views;
using OTPAuthentication.Views.OtpAuthentication;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class OTPPageViewModel : BaseViewModel
    {
        private string numberOne;
        private string numberTwo;
        private string numberThree;
        private string numberFour;
        private string numberFive;
        private string numberSix;

        private string FullOtp;
        private string otpNumber;
        private string mobileNumber ;

        public Command VerifyOTP { get; set; }
        public OTPPageViewModel()
        {
            
            VerifyOTP = new Command(WriteOTP);
            MobileNumber = Preferences.Get("MobileNumber", string.Empty);
        }


        private async void WriteOTP(object obj)
        {
            var otpNumber = $"{NumberOne}{NumberTwo}{NumberThree}{NumberFour}{NumberFive}{NumberSix}";
            FullOtp = Preferences.Get("Number", string.Empty);
            if(otpNumber != FullOtp)
            {
                await App.Current.MainPage.DisplayAlert("Aleart", "OTP is Not Correct", "Ok");
            }
            else if (otpNumber == FullOtp)
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginSuccessfull());
            }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public string OtpNumber
        {
            get { return otpNumber; }
            set { otpNumber = value; }
        }

        public string NumberOne
        {
            get { return numberOne; }
            set { numberOne = value; }
        }
        public string NumberTwo
        {
            get { return numberTwo; }
            set { numberTwo = value; }
        }
        public string NumberThree
        {
            get { return numberThree; }
            set { numberThree = value; }
        }
        public string NumberFour
        {
            get { return numberFour; }
            set { numberFour = value; }
        }
        public string NumberFive
        {
            get { return numberFive; }
            set { numberFive = value; }
        }
        public string NumberSix
        {
            get { return numberSix; }
            set { numberSix = value; }
        }

    }
}
