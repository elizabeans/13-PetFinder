using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace PetFinder.Core.Services
{
    public class SmsService
    {
        private const string TwilioAccountSid = "ACd3a8e7e98d1f649309c84db27749857b";
        private const string TwilioAuthToken = "544afd098977a0aee24173cd53fa9bd2";
        private const string FromNumber = "+12402921813";

        public static void SendSMS(string to, string message)
        {
            var twilio = new TwilioRestClient(TwilioAccountSid, TwilioAuthToken);

            twilio.SendMessage(FromNumber, to, message);
        }
    }
}