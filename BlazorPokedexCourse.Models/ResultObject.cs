using Newtonsoft.Json;

namespace BlazorPokedexCourse.Models
{
    public class ResultObject
    {
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; } = null!;
    }
}