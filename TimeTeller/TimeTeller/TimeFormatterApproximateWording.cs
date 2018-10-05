using System;

namespace TimeTeller 
{
    class TimeFormatterApproximateWording : TimeFormatter
    {
        public static readonly int SECONDS_IN_A_HALF_MINUTE = 30;
        public static readonly int HOURS_IN_A_QUARTER_OF_A_DAY = 6;
        public static readonly int MINUTE_TO_START_FUZZING_INTO_NEXT_HOUR = 35;

        public String FormatTime(ClockInterface clock)
        {
            String formattedTime = "";

            String[] namesOfTheHours = { "twelve", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" };
            String[] fuzzyTimeWords = { "about", "a little after", "about ten after", "about a quarter after", "about twenty after", "almost half past", "about half past", "almost twenty before", "about twenty before", "about a quarter of", "about ten of", "almost", "about" };
            String[] quadrantOfTheDay = { "at night", "in the morning", "in the afternoon", "in the evening" };

            int hour = clock.GetHour();
            int minute = clock.GetMinute();
            int second = clock.GetSecond();

            if (second >= SECONDS_IN_A_HALF_MINUTE) minute++;

            formattedTime += fuzzyTimeWords[(minute + 2) / 5] + " ";

            if (minute < MINUTE_TO_START_FUZZING_INTO_NEXT_HOUR)
            {
                formattedTime += namesOfTheHours[hour % namesOfTheHours.Length];
            }
            else
            {
                formattedTime += namesOfTheHours[(hour + 1) % namesOfTheHours.Length];
            }

            formattedTime += " " + quadrantOfTheDay[hour / HOURS_IN_A_QUARTER_OF_A_DAY];

            if (clock.GetTimeZone() == "UTC")
            {
                formattedTime += " Zulu";
            }

            return formattedTime;
        }

    }
}
