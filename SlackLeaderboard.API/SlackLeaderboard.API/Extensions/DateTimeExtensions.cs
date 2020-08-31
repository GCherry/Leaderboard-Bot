using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackLeaderboard.API.Extensions
{
    public static class DateTimeExtensions
    {
        static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromUnixTime(this double unixTimeStamp)
        {
            return _epoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }
    }
}
