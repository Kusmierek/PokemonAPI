using PokemonApp.Models;

namespace PokemonApp.Models
{
    public class User
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public ICollection<PokemonUser> PokemonUsers { get; set; }

    }
}
