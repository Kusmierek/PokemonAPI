using PokemonApp.Data;
using PokemonApp.Models;
using PokemonReviewApp.Models;
using System.Diagnostics.Metrics;

namespace PokemonApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonUsers.Any())
            {
                var PokemonUsers = new List<PokemonUser>()
                {
                    new PokemonUser()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            Description = "Electric Rat",
                            ImageUrl = "",
                            Agility = 10,
                            Attack = 10,
                            Intelligence = 10,
                            Defense = 10
                        },
                        User = new User()
                        {
                            Name = "Jack",
                            Email = "Jack@gmail.com",
                            Password = "Jack123",
                            Money = 0
                        }
                    },
                    new PokemonUser()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            Description = "Turtle",
                            ImageUrl = "",
                            Agility = 10,
                            Attack = 10,
                            Intelligence = 10,
                            Defense = 10
                        },
                        User = new User()
                        {
                            Name = "Turtle",
                            Email = "turtle@gmail.com",
                            Password = "Turtle123",
                            Money = 0
                        }
                    },
                    new PokemonUser()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Chalizard",
                            Description = "Dragon",
                            ImageUrl = "",
                            Agility = 10,
                            Attack = 10,
                            Intelligence = 10,
                            Defense = 10
                        },
                        User = new User()
                        {
                            Name = "Dragon",
                            Email = "Dragon@gmail.com",
                            Password = "Dragon123",
                            Money = 0
                        }
                    }
                };
                dataContext.PokemonUsers.AddRange(PokemonUsers);
                dataContext.SaveChanges();
            }
        }
    }
}