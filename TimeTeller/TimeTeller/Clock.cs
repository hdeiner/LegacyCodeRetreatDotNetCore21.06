using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTeller
{
    class Clock : ClockInterface
    {
        private DateTimeOffset dateTime;
        private String timeZone;

        public Clock()
        {
            this.timeZone = "LOCAL";
            dateTime = new DateTimeOffset(DateTime.Now);
        }

        public Clock(String timeZone)
        {
            this.timeZone = timeZone;
            if (!timeZone.Equals("LOCAL"))
            {
                dateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(timeZone));
            }
            else
            {
                dateTime = new DateTimeOffset(DateTime.Now);
            }
        }

        public int GetHour()
        {
            return dateTime.Hour;
        }

        public int GetMinute()
        {
            return dateTime.Minute;
        }

        public int GetSecond()
        {
            return dateTime.Second;
        }

        public String GetTimeZone()
        {
            return timeZone;
        }
    }
}
