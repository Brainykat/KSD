using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Domain.Entities
{
    public class SMSLog
    {
        public static SMSLog Create(string msisdn, string message, bool isSent = false) =>
            new SMSLog(msisdn, message, isSent);
        private SMSLog(string msisdn, string message, bool isSent)
        {
            this.msisdn = msisdn ?? throw new ArgumentNullException(nameof(msisdn));
            Message = message ?? throw new ArgumentNullException(nameof(message));
            IsDelivered = false;
            IsSent = isSent;
        }
        private SMSLog() { }
        public int Id { get; set; }
        public string msisdn { get; set; }
        public string Message { get; set; }
        public bool IsSent { get; set; }
        public bool IsDelivered { get; set; }
    }
}
