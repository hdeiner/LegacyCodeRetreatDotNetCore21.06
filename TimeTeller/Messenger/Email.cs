using System;
using System.Net;
using System.Net.Mail;

namespace Messenger
{
    class Email : Message
    {
        public Email(String configFileName) : base(configFileName)
        {
        }

        public void Send(String formattedTime)
        {
            try
            {
                NetworkCredential networkCredential = new NetworkCredential(
                    GetConfigProperty("smtpUserId"),
                    GetConfigProperty("smtpUserPassword")
                );

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(GetConfigProperty("emailFromAddress")),
                    Subject = GetConfigProperty("emailSubject"),
                    Body = GetConfigProperty("eMailMessage") + " " + formattedTime
                };

                mailMessage.To.Add(new MailAddress(GetConfigProperty("emailToAddress")));

                SmtpClient smtpClient = new SmtpClient()
                {
                    Port = Convert.ToInt32(GetConfigProperty("smtpPort")),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = Convert.ToBoolean(GetConfigProperty("smtpUseDefaultCredentials")),
                    Host = GetConfigProperty("smtpHost"),
                    EnableSsl = Convert.ToBoolean(GetConfigProperty("smtpEnableSsl")),
                    Credentials = networkCredential
                };

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
