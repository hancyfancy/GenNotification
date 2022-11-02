using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNotification.Service.Utilities.Interface
{
    public interface ISmsDespatcher
    {
        void SendSms(string smsUsername, string smsApiKey, string phoneNumber, string sender, string body);
    }
}
