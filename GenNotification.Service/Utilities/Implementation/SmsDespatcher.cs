using GenNotification.Service.Utilities.Interface;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;
using IO.ClickSend.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenNotification.Service.Utilities.Implementation
{
    public class SmsDespatcher : ISmsDespatcher
    {
        public void SendSms(string smsUsername, string smsApiKey, string phoneNumber, string sender, string body)
        {
            try
            {
                var configuration = new Configuration()
                {
                    Username = smsUsername,
                    Password = smsApiKey
                };

                var smsApi = new SMSApi(configuration);

                var listOfSms = new List<SmsMessage>
                {
                    new SmsMessage(
                        to: phoneNumber,
                        body: body,
                        source: sender
                    )
                };

                var smsCollection = new SmsMessageCollection(listOfSms);

                var response = smsApi.SmsSendPost(smsCollection);
            }
            catch (Exception e)
            {

            }
        }
    }
}
