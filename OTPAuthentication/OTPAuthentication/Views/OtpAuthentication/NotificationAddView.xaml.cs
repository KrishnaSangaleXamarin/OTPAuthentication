using OTPAuthentication.Models;
using OTPAuthentication.ViewModels.OtpAuthentication;
using SQLite;
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
    public partial class NotificationAddView : ContentPage
    {
        public NotificationAddView()
        {
            InitializeComponent();
            this.BindingContext = new NotificationAddViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var person = new Notification()
            {
                Title = title.Text,
                Message = message.Text
            };

            //Connection with database
            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Notification>();


            int rows = connection.Insert(person);
            connection.Close();

            if (rows > 0)
            {
                DisplayAlert("Success", "Notification Added Successfully", "Ok");
            }
            else
            {
                DisplayAlert("Failure", "Filed to Add Notification", "Ok");
            }



            //Clearing entries after data saved to database
            title.Text = "";
            message.Text = "";

            // return to homepage
            Navigation.PopAsync();
        }
    }
}