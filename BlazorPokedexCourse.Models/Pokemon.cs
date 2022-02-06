using Newtonsoft.Json;

namespace BlazorPokedexCourse.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("types")]
        public List<Type> Types { get; set; } = null!;

        [JsonProperty("sprites")]
        public List<Sprite> Sprites { get; set; } = null!;
    }
}
