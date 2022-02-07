﻿using BlazorPokedexCourse.Models;
using Newtonsoft.Json;

namespace BlazorPokedexCourse.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private HttpClient _httpClient;

        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultObject> GetAllPokemons(PaginationParameters parameters)
        {
            return JsonConvert.DeserializeObject<ResultObject>(
                await _httpClient.GetStringAsync($"pokemon?offset={parameters.Offset}&limit={parameters.PageSize}"))!;
        }

        public async Task<Pokemon?> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
