using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.UI.Shared.ViewModels
{
    public class SMSLogView
    {
        public int Id { get; set; }
        public string msisdn { get; set; }
        public string Message { get; set; }
        public bool IsSent { get; set; }
        public bool IsDelivered { get; set; }
    }
}
