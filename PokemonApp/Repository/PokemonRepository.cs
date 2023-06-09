﻿using PokemonApp.Data;
using PokemonReviewApp.Models;

namespace PokemonApp.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}
