namespace SlackLeaderboard.API.Models
{
    public class JokeModel
    {
        string _joke;

        public string Joke
        {
            get => _joke;
            set => _joke = value?.Replace("&quot;", "\"");
        }

        public int Id { get; set; }
    }
}
