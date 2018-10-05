using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TimeTeller
{
    public class ClockTests
    {
        [Fact]
        public void LocalTimeAndDefaultTimeAreTheSame()
        {
            Clock defaultTime = new Clock();
            Clock localTime = new Clock("LOCAL");
            Assert.Equal(defaultTime.GetHour(), localTime.GetHour());
            Assert.Equal(defaultTime.GetMinute(), localTime.GetMinute());
            Assert.Equal(defaultTime.GetSecond(), localTime.GetSecond());
        }

        [Fact]
        public void NewYorkIsLosAngelesPlus3()
        {
            Clock estTime = new Clock("Eastern Standard Time");
            Clock pstTime = new Clock("Pacific Standard Time");
            Assert.Equal(estTime.GetHour(), (pstTime.GetHour() + 3) % 24);
        }

    }
}
