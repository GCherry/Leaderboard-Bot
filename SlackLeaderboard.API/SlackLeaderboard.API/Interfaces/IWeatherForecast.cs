using SlackLeaderboard.API.Models;
using System.Collections.Generic;

namespace SlackLeaderboard.API.Interfaces
{
    public interface IWeatherForecast
    {
        IEnumerable<WeatherForecast> GetSummaries();
    }
}
