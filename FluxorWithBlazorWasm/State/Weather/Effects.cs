﻿using Fluxor;
using static FluxorWithBlazorWasm.Pages.FetchData;
using System.Net.Http.Json;
using FluxorWithBlazorWasm.Models;

namespace FluxorWithBlazorWasm.State.Weather
{
    public class Effects
    {
        private readonly HttpClient Http;

        public Effects(HttpClient http)
        {
            Http = http;
        }

        [EffectMethod]
        public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            if (forecasts is not null)
            {
                dispatcher.Dispatch(new FetchDataResultAction(forecasts: forecasts!));
            }
        }
    }
}
