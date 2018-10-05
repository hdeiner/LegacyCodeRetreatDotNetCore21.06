using System;

namespace TimeTeller
{
     class ClockForTesting : ClockInterface
    {
        private int hour;
        private int minute;
        private int second;
        private String timeZone;

        public ClockForTesting(int hour, int minute, int second, String timeZone) 
        {
            this.timeZone = timeZone;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int GetHour() { return hour; }

        public int GetMinute() {  return minute; }

        public int GetSecond() { return second; }

        public String GetTimeZone() { return timeZone; }
    }
}
