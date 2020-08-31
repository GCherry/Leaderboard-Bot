using Newtonsoft.Json;

namespace SlackLeaderboard.API.Extensions
{
    public static class StringExtensions
    {
        public static T To<T>(this string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
