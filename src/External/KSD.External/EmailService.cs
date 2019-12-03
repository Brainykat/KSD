using KSD.ServiceContracts;
using System;
using System.Net;
using System.Net.Mail;

namespace KSD.External
{
    public class EmailService : IEmailService
    {
        public bool SendMail(string ToEmail, string Subj, string Message, string cc = "", string bcc = "")
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                MailMessage mailMessage = new MailMessage();
                string email = "brainykatceo@gmail.com";
                string header = "Ushirika";
                string pwd = "1Plus2is3!@";
                mailMessage.From = new MailAddress(email, header);
                mailMessage.Subject = Subj;
                mailMessage.Body = Message;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.Normal;
                //mailMessage.Priority = MailPriority.High;
                if (ToEmail.Length > 0)
                {
                    string[] ToMuliId = ToEmail.Split(',');
                    foreach (string ToEMailId in ToMuliId)
                    {
                        mailMessage.To.Add(new MailAddress(ToEMailId)); //adding multiple TO Email Id  
                    }
                }
                if (cc.Length > 0)
                {
                    string[] CCId = cc.Split(',');
                    foreach (string CCEmail in CCId)
                    {
                        mailMessage.CC.Add(new MailAddress(CCEmail)); //Adding Multiple CC email Id  
                    }
                }
                if (bcc.Length > 0)
                {
                    string[] bccid = bcc.Split(',');
                    foreach (string bccEmailId in bccid)
                    {
                        mailMessage.Bcc.Add(new MailAddress(bccEmailId)); //Adding Multiple BCC email Id  
                    }
                }

                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = mailMessage.From.Address;
                NetworkCred.Password = pwd;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Port = 587;
                smtp.Send(mailMessage);
                return true;
            }
            catch (System.Exception)
            {

            }
            return false;
        }
    }
}
