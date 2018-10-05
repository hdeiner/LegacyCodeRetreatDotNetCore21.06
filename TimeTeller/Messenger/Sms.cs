using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Messenger
{
    class Sms : Message
    {
        private MessageResource message;

        public Sms(String configFileName) : base(configFileName)
        {
        }

        public void Send(String formattedTime)
        {
            TwilioClient.Init(GetConfigProperty("account.sid"), GetConfigProperty("auth.token"));

            message = MessageResource.Create(to: new PhoneNumber(GetConfigProperty("number.to")),
                                        from: new PhoneNumber(GetConfigProperty("number.from")),
                                        body: formattedTime);

        }

        public MessageResource.StatusEnum GetStatus()
        {
            return message.Status;
        }
    }
}
