using OTPAuthentication.ViewModels.OtpAuthentication.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPAuthentication.Views.OtpAuthentication.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsPopup : Popup
    {
        public EventsPopup()
        {
            InitializeComponent();
            this.BindingContext = new EventsViewModel();
        }
    }
}