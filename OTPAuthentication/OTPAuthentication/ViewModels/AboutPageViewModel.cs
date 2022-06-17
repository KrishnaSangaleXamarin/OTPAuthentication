using OTPAuthentication.Models;
using OTPAuthentication.Views.OtpAuthentication;
using SQLite;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OTPAuthentication.ViewModels
{
    public class AboutPageViewModel : BaseViewModel
    {
        private string totalCount;
        public string TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }
        public Command GoToNotificationPage{ get; }
        public AboutPageViewModel()
        {
            GoToNotificationPage = new Command(OpenAsync);
            var connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();
            TotalCount = connection.Table<Notification>().Count().ToString();
        }

        private void OpenAsync()
        {
            App.Current.MainPage.Navigation.PushAsync(new NotificationPage());
        }
    }
}