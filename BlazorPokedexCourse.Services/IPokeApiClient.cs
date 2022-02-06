using BlazorPokedexCourse.Models;

namespace BlazorPokedexCourse.Services
{
    public interface IPokeApiClient
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task<Pokemon?> GetPokemon(string name);
    }
}
