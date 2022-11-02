using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNotification.Service.Utilities.Interface
{
    public interface IEmailDespatcher
    {
        void SendEmail(string host, int port, bool useSsl, string emailAddress, string username, string password, string title, string body);
    }
}
