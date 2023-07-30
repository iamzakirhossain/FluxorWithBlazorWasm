using Fluxor;
using FluxorWithBlazorWasm.Models;
using static FluxorWithBlazorWasm.Pages.FetchData;

namespace FluxorWithBlazorWasm.State.Weather
{

    public class FetchDataResultAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public FetchDataResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
