using OTPAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Plugin.Calendar.Models;

namespace OTPAuthentication.ViewModels.OtpAuthentication.Tabs
{
    public class EventsViewModel : BaseViewModel
    {
        private DateTime today;
        public DateTime Today
        {
            get { return today; }
            set { today = DateTime.Today; }
        }
        public ICommand EventSelectedCommand => new Command(async (item) => await ExecuteEventSelectedCommand(item));
        public EventCollection Events { get; set; }
        public EventsViewModel()
        {
            Events = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event1", Description = "This is Cool event1's description!" },
                    new EventModel { Name = "Cool event2", Description = "This is Cool event2's description!" }
                },
                // 5 days from today
                [DateTime.Now.AddDays(5)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event3", Description = "This is Cool event3's description!" },
                    new EventModel { Name = "Cool event4", Description = "This is Cool event4's description!" }
                },
                // 3 days ago
                [DateTime.Now.AddDays(-3)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event5", Description = "This is Cool event5's description!" }
                },
                // custom date
                [new DateTime(2020, 3, 16)] = new List<EventModel>
                {
                    new EventModel { Name = "Cool event6", Description = "This is Cool event6's description!" }
                }
            };
        }

        private async Task ExecuteEventSelectedCommand(object item)
        {
            if (item is EventModel eventModel)
            {
                await App.Current.MainPage.DisplayAlert(eventModel.Name, eventModel.Description, "Ok");
            }
        }
    }
}
