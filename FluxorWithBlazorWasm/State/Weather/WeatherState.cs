using Fluxor;
using FluxorWithBlazorWasm.Models;
using static FluxorWithBlazorWasm.Pages.FetchData;

namespace FluxorWithBlazorWasm.State.Weather
{
    [FeatureState]
    public class WeatherState
    {
        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        private WeatherState() { }
        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts;
        }
    }
}
