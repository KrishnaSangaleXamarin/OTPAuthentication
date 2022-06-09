using OTPAuthentication.Views.OtpAuthentication;
using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels.OtpAuthentication
{
    public class MobileNumberViewModel : BaseViewModel
    {
        private string mobileNumber;
        private string verifiedImage;
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        } 

        public string MyrecentOTP { get; set; }
        public string VerifiedImage
        {
            get { return verifiedImage; }
            set { verifiedImage = value; }
        }
        public Command SendNumber { get; set; }
        public Command ValidateMobileNumber { get; set; }
        public MobileNumberViewModel()
        {
            SendNumber = new Command(SendOtpToNumber);
            //ValidateMobileNumber = new Command(ValidateEntry);
        }

        //private void ValidateEntry(object obj)
        //{
        //    if (MobileNumber.Length < 10 || string.IsNullOrEmpty(MobileNumber))
        //    {
        //        VerifiedImage = "";
        //    }
        //    else
        //    {
        //        VerifiedImage = "check.png";
        //    }
        //}

        private void SendOtpToNumber(object obj)
        {
            try
            {
                if (MobileNumber == null || string.IsNullOrEmpty(MobileNumber) || MobileNumber.Length <10)
                {
                    App.Current.MainPage.DisplayAlert("Aleart", "Enter Correct MobileNumber", "Ok");
                }
                else
                {
                    string accountSid = "ACac03f357a0ee55fcd0a9860ce87ba499";
                    string authToken = "86e4df842d0dce21865551bbfce117cb";



                    TwilioClient.Init(accountSid, authToken);



                    Random generator = new Random();
                    string randomotp = generator.Next(0, 999999).ToString("D6");



                    var message = MessageResource.Create(
                    body: "Your Otp is " + randomotp,
                    from: new Twilio.Types.PhoneNumber("+18644001647"),
                    to: new Twilio.Types.PhoneNumber($"+91{MobileNumber}")
                    );
                    Console.WriteLine(message.Sid);



                    MyrecentOTP = randomotp;
                    Preferences.Set("Number", randomotp);
                    Preferences.Set("MobileNumber", MobileNumber);
                    App.Current.MainPage.Navigation.PushAsync(new OTPPage());
                }
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Aleart", ex.Message, "Ok");
            }
            

        }

        

    }
}
