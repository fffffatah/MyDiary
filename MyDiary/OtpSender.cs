using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MyDiary
{
    public class OtpSender
    {
        public void Send(int otp, string phoneNumber)
        {
            TwilioClient.Init(ConfigurationManager.AppSettings.Get("twilioAccountSid"), ConfigurationManager.AppSettings.Get("twilioAuthToken"));
            var message = MessageResource.Create(
                body: "Your OTP for MyDiary Signup is: " + otp,
                from: new Twilio.Types.PhoneNumber(ConfigurationManager.AppSettings.Get("twilioPhoneNumber")),
                to: new Twilio.Types.PhoneNumber("+88" + phoneNumber)
            );
        }
    }
}
