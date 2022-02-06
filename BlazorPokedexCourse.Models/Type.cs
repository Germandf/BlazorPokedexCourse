using Newtonsoft.Json;

namespace BlazorPokedexCourse.Models
{
    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("type")]
        public PokemonType PokemonType { get; set; } = null!;
    }

    public class PokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}
