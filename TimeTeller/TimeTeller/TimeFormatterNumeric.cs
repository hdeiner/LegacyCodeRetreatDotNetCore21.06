using System;

namespace TimeTeller
{
    class TimeFormatterNumeric : TimeFormatter
    {
        public String FormatTime(ClockInterface clock)
        {
            String formattedTime = clock.GetHour().ToString("00") + ":" +  
                                   clock.GetMinute().ToString("00") + ":" + 
                                   clock.GetSecond().ToString("00");
            if (clock.GetTimeZone() == "UTC")
            {
                formattedTime += "Z";
            }
            return formattedTime;
        }
    }
}
