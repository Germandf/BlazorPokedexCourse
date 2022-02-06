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

        public Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public async Task<Pokemon?> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
                await _httpClient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
