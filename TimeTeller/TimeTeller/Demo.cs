using System;
using Messenger;

namespace TimeTeller
{
    class Demo
    {
        static void Main(string[] args)
        {
            Email eMail = new Email("configEmail.properties");
            Sms sms = new Sms("configSms.properties");

            Console.WriteLine("Local time formatted numerically");
            Console.WriteLine(new TimeFormatterNumeric().FormatTime(new Clock()));

            Console.WriteLine("UTC time formatted numerically");
            Console.WriteLine(new TimeFormatterNumeric().FormatTime(new Clock("UTC")));

            Console.WriteLine("India Standard Time formatted numerically");
            Console.WriteLine(new TimeFormatterNumeric().FormatTime(new Clock("India Standard Time")));

            Console.WriteLine("Local time formatted with approximate wording");
            Console.WriteLine(new TimeFormatterApproximateWording().FormatTime(new Clock()));

            Console.WriteLine("UTC time formatted with approximate wording");
            Console.WriteLine(new TimeFormatterApproximateWording().FormatTime(new Clock("UTC")));

            Console.WriteLine("India Standard Time formatted with approximate wording");
            Console.WriteLine(new TimeFormatterApproximateWording().FormatTime(new Clock("India Standard Time")));

            Console.WriteLine("Sending eMail with local time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock()));

            Console.WriteLine("Sending eMail with UTC time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock("UTC")));

            Console.WriteLine("Sending eMail with India Standard Time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock("India Standard Time")));

            Console.WriteLine("Sending eMail with local time formatted with approximate wording");
            eMail.Send(new TimeFormatterApproximateWording().FormatTime(new Clock()));

            Console.WriteLine("Sending eMail with UTC time formatted with approximate wording");
            eMail.Send(new TimeFormatterApproximateWording().FormatTime(new Clock("UTC")));

            Console.WriteLine("Sending eMail with India Standard Time formatted with approximate wording");
            eMail.Send(new TimeFormatterApproximateWording().FormatTime(new Clock("UTC")));

            Console.WriteLine("Sending eMail with local time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock()));

            Console.WriteLine("Sending eMail with UTC time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock("UTC")));

            Console.WriteLine("Sending eMail with India Standard Time formatted numerically");
            eMail.Send(new TimeFormatterNumeric().FormatTime(new Clock("India Standard Time")));

            Console.WriteLine("Sending SMS with local time formatted with approximate wording");
            sms.Send(new TimeFormatterApproximateWording().FormatTime(new Clock()));

            Console.WriteLine("Sending SMS with UTC time formatted with approximate wording");
            sms.Send(new TimeFormatterApproximateWording().FormatTime(new Clock("UTC")));

            Console.WriteLine("Sending SMS with India Standard Time formatted with approximate wording");
            sms.Send(new TimeFormatterApproximateWording().FormatTime(new Clock("India Standard Time")));

            Console.WriteLine("Demo complete.  Press return to continue.");
            Console.Read();
        }
    }
}
