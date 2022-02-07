using BlazorPokedexCourse.Models;

namespace BlazorPokedexCourse.Services
{
    public interface IPokeApiClient
    {
        Task<ResultObject> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon?> GetPokemon(string name);
    }
}
