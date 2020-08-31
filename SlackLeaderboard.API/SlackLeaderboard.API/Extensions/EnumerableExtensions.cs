using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackLeaderboard.API.Extensions
{
    static public class EnumerableExtensions
    {
        static readonly Random _random = new Random((int)DateTime.Now.Ticks);

        internal static T RandomElement<T>(this IList<T> enumerable)
            => enumerable.ElementAt(_random.Next(0, enumerable.Count));
    }
}
