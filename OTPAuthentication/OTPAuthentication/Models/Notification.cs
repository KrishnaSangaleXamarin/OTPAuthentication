using System;
using System.Collections.Generic;
using System.Text;

namespace OTPAuthentication.Models
{
    public class Notification
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Image { get; set; }

    }
}
