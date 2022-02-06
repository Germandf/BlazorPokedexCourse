using Newtonsoft.Json;

namespace BlazorPokedexCourse.Models
{
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string Front { get; set; } = null!;
        [JsonProperty("back_default")]
        public string Back { get; set; } = null!;
    }
}