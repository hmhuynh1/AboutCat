using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;


namespace AboutCatFinalProjectHuynhLavana.Models
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options)
            : base(options)
        { }

        public DbSet<Cat> Cat { get; set; } = null!;
        
        protected override void OnModelCreating(
        ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Cat>().HasData(
            new Cat
            {
                CatId = 1,
                CatName = "Casablanca",
                CatBreed = "T",
                CatFavoriteFood = "c",
                CatFavoriteToy = "t",
                Advice = "ho"
            }
        ); 

        }

    }
}


