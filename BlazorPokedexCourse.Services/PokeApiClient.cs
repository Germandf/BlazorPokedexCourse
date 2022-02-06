using BlazorPokedexCourse.Models;
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

        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemonList = JsonConvert.DeserializeObject<ResultObject>(
                await _httpClient.GetStringAsync($"pokemon?offset=24&limit=24"));

            var resultList = new List<Pokemon>();

            foreach (var pokemon in pokemonList.Pokemons)
                resultList.Add(await GetPokemon(pokemon.Name));

            return resultList;
        }

        public async Task<Pokemon?> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
