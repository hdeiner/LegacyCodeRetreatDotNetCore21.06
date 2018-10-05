using System;
using Xunit;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TimeTeller;

namespace Messenger
{
    public class SmsTests
    {
        [Fact]
        public void SendAndValidateSms()
        {
            Sms sms = new Sms("configSms.properties");

            sms.Send(new TimeFormatterNumeric().FormatTime(new ClockForTesting(12, 0, 0, "LOCAL")));

            Assert.Contains(sms.GetStatus(), new MessageResource.StatusEnum[] { MessageResource.StatusEnum.Queued, MessageResource.StatusEnum.Accepted, MessageResource.StatusEnum.Delivered, MessageResource.StatusEnum.Received, MessageResource.StatusEnum.Receiving, MessageResource.StatusEnum.Sending, MessageResource.StatusEnum.Sent });
        }

    }
}
