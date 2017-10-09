using System;

namespace NetBinance.Converters
{
    public static class DateTimeExtensions
    {
        public static DateTime ToDateTime(this long timestamp)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(timestamp);
            var dateTime = dateTimeOffset.UtcDateTime;

            return dateTime;
        }

        public static long ToTimestamp(this DateTime dateTime)
        {
            return ((DateTimeOffset)dateTime).ToUnixTimeMilliseconds();
        }
    }
}
