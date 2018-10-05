using System;
using Xunit;

namespace TimeTeller
{
    public class TimeFormatterTests
    {

        [Fact]
        public void LocalTimeCurrent()
        {
            Assert.Equal(GetFormattedTimeLocal(DateTime.Now), new TimeFormatterNumeric().FormatTime(new Clock()));
        }

        [Fact]
        public void ZuluTimeCurrent()
        {
            Assert.Equal(GetFormattedTimeUTC(DateTime.UtcNow), new TimeFormatterNumeric().FormatTime(new Clock("UTC")));
        }

        [Fact]
        public void LocalTimeNumeric102445()
        {
            Assert.Equal("10:24:45", new TimeFormatterNumeric().FormatTime(new ClockForTesting(10, 24, 45, "LOCAL")));
        }

        [Fact]
        public void ZuluTimeNumeric102445()
        {
            Assert.Equal("10:24:45Z", new TimeFormatterNumeric().FormatTime(new ClockForTesting(10, 24, 45, "UTC")));
        }

        [Fact]
        public void ZuluTimeInWords000005()
        {
            Assert.Equal("about twelve at night Zulu", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(0, 0, 5, "UTC")));
        }

        [Fact]
        public void LocalTimeInWords000005()
        {
            Assert.Equal("about twelve at night", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(0, 0, 5, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords090239()
        {
            Assert.Equal("a little after nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 2, 39, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords090949()
        {
            Assert.Equal("about ten after nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 9, 49, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords091702()
        {
            Assert.Equal("about a quarter after nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 17, 2, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords091902()
        {
            Assert.Equal("about twenty after nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 19, 2, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords092312()
        {
            Assert.Equal("almost half past nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 23, 12, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords093112()
        {
            Assert.Equal("about half past nine in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 31, 12, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords093623()
        {
            Assert.Equal("almost twenty before ten in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 36, 23, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords093823()
        {
            Assert.Equal("about twenty before ten in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 38, 23, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords094145()
        {
            Assert.Equal("about a quarter of ten in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 43, 45, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords094945()
        {
            Assert.Equal("about ten of ten in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 49, 45, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords095801()
        {
            Assert.Equal("almost ten in the morning", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(9, 53, 1, "LOCAL")));
        }

        [Fact]
        public void LocalTimeInWords120105()
        {
            Assert.Equal("about twelve in the afternoon", new TimeFormatterApproximateWording().FormatTime(new ClockForTesting(12, 1, 5, "LOCAL")));
        }

        private String GetFormattedTimeLocal(DateTime clock)
        {
            int localHour = clock.Hour;
            int localMinute = clock.Minute;
            int localSecond = clock.Second;
            return localHour.ToString("00") + ":" + localMinute.ToString("00") + ":" + localSecond.ToString("00");
        }

        private String GetFormattedTimeUTC(DateTime clock)
        {
            int localHour = clock.Hour;
            int localMinute = clock.Minute;
            int localSecond = clock.Second;
            return localHour.ToString("00") + ":" + localMinute.ToString("00") + ":" + localSecond.ToString("00") + "Z";
        }
    }
}
