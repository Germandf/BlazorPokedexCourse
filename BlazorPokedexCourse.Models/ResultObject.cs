using Newtonsoft.Json;

namespace BlazorPokedexCourse.Models
{
    public class ResultObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; } = null!;
    }
}