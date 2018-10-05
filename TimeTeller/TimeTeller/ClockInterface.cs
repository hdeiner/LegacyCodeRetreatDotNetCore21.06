using System;

namespace TimeTeller
{
    public interface ClockInterface
    {
        int GetHour();
        int GetMinute();
        int GetSecond();
        String GetTimeZone();
    }
}
