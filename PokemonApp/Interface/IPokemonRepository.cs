using PokemonReviewApp.Models;

namespace PokemonApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
