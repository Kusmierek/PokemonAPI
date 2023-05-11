using Microsoft.EntityFrameworkCore;
using PokemonApp.Models;

namespace PokemonApp.Data
{
    public class DataContext : DbContext
 {
        public DataContext() : base() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
            
        }

        public DbSet<Pokemon> Pokemons{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PokemonUser> PokemonUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonUser>()
                .HasKey(x => new { x.PokemonId, x.UserId });
            modelBuilder.Entity<PokemonUser>()
                .HasOne(x => x.Pokemon)
                .WithMany(x => x.PokemonUsers)
                .HasForeignKey(x => x.PokemonId);
            modelBuilder.Entity<PokemonUser>()
                .HasOne( x => x.User)
                .WithMany( x => x.PokemonUsers)
                .HasForeignKey(x => x.UserId);  

        }
    }
}
