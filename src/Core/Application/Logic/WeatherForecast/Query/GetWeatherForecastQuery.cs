using Application.Responses.WeatherForecast;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Logic.WeatherForecast.Query
{
    public class GetWeatherForecastQuery : IRequest<IEnumerable<GetWeatherForecastResponse>>
    {
        public GetWeatherForecastQuery()
        { }
    }
    internal class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, IEnumerable<GetWeatherForecastResponse>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly Random _random;
        public GetWeatherForecastQueryHandler()
        {
            _random = new Random();
        }

        public async Task<IEnumerable<GetWeatherForecastResponse>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var result = Enumerable.Range(1, 5).Select(index => new GetWeatherForecastResponse
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = _random.Next(-20, 55),
                Summary = Summaries[_random.Next(Summaries.Length)]
            })
           .ToArray();
            return  await Task.FromResult(result);
        }
    }
}
