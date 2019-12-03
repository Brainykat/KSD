using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.ServiceContracts
{
    public interface IEmailService
    {
        bool SendMail(string ToEmail, string Subj, string Message, string cc = "", string bcc = "");
    }
}
