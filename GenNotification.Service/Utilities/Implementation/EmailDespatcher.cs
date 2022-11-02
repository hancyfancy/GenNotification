using GenNotification.Service.Utilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GenNotification.Service.Utilities.Implementation
{
    public class EmailDespatcher : IEmailDespatcher
    {
        public void SendEmail(string host, int port, bool useSsl, string emailAddress, string username, string password, string title, string body)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(username);
                    message.Subject = title;
                    message.Body = body;
                    message.To.Add(new MailAddress(emailAddress));
                    message.IsBodyHtml = true;
                    smtp.Port = port;
                    smtp.Host = host;
                    smtp.EnableSsl = useSsl;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(username, password);
                    smtp.Send(message);
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
