﻿using PokemonApp.Models;

namespace PokemonApp.Models
{
    public class PokemonUser
    {
        public int PokemonId { get; set; }
        public int UserId { get; set; }
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }  

    }
}
