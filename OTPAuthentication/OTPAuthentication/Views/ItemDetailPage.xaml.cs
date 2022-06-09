using OTPAuthentication.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OTPAuthentication.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}