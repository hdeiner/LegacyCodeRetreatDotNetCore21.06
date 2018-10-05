using System;

namespace TimeTeller
{
    interface TimeFormatter
    {
        String FormatTime(ClockInterface clock);
    }
}
