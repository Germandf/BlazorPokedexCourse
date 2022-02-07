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
        public Sprite Sprite { get; set; } = null!;
        
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }
        
        [JsonProperty("weight")]
        public int Weight { get; set; }
        
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
