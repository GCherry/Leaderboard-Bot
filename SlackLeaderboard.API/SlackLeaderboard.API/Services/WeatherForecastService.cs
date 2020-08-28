﻿using SlackLeaderboard.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackLeaderboard.API.Services
{
    public class WeatherForecastService : IWeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<IEnumerable<WeatherForecast>> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeatherForecast> GetSummaries()
        {
            var rng = new Random();
            var summaries =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return summaries;
        }
    }
}