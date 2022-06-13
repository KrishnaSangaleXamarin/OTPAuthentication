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
    public partial class NotificationAddView : ContentPage
    {
        public NotificationAddView()
        {
            InitializeComponent();
            this.BindingContext = new NotificationAddViewModel();
        }
    }
}