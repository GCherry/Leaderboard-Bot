using SlackLeaderboard.API.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using SlackLeaderboard.API.Models;
using SlackLeaderboard.API.Extensions;

namespace SlackLeaderboard.API.Services
{
    public class JokeService : IJokeService
    {
        readonly IList<string> _positiveEmoji = new List<string>
        {
            ":smile:",
            ":smirk:",
            ":clap:",
            ":joy:",
            ":grin:",
            ":yum:",
            ":sweat_smile:",
            ":laughing:",
            ":smiley:",
            ":rolling_on_the_floor_laughing:"
        };

        readonly IHttpClientFactory _httpClientFactory;

        public JokeService(IHttpClientFactory httpClientFactory)
            => _httpClientFactory = httpClientFactory;

        public async Task<JokeResponse> GetJokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var json =
                await client.GetStringAsync(
                    "https://api.icndb.com/jokes/random?limitTo=[nerdy]");

            return json.To<JokeResponse>();
        }

        public string GetRandomJokeEmoji()
        {
            return _positiveEmoji.RandomElement();
        }
    }
}
