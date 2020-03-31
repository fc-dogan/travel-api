using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
      public TravelContext(DbContextOptions<TravelContext> options)
          : base(options)
      {
      }

  protected override void OnModelCreating(ModelBuilder builder)
  {
  //   builder.Entity<Destination>()
  //       .HasData(
  //          new Destination {DestinationId = 1, Country = "Turkey", City = "Istanbul"},
  //          new Destination {DestinationId = 2, Country = "France", City = "Paris"},
  //          new Destination {DestinationId = 3, Country = "Italy", City = "Rome"}
  //       );

    builder.Entity<Review>()
        .HasData(
           new Review {ReviewId = 1, Country = "Turkey", City = "Istanbul", Author = "Author1", Rating = 5 , Description = "Istanbul is one of the truly great romantic cities; home to a layering of civilization on civilization, of empire built on empire" },
           new Review {ReviewId = 2, Country = "France", City = "Paris", Author = "Author1", Rating = 4 ,  Description = "Paris is regarded as one of the most dynamic cities in Europe, and for good reason: the city assaults the senses; demanding to be seen, heard, touched, tasted and smelled." },
           new Review {ReviewId = 3, Country = "Italy", City = "Rome", Author = "Author1", Rating = 5 , Description = "An in depth vacation to one of the most enduring cities in Europe! Rome is the heart of Italy; once the center of the world`s greatest empire, the Eternal City has some of the finest art and architecture to survive from the last 2,000 years." },
           new Review {ReviewId = 4, Country = "Turkey", City = "Istanbul", Author = "Author4", Rating = 5 , Description = "From the holy sites of Sultanahmet and the 19th-century European elegance of Beyoğlu to the high fashion of Nişantaşı, the vibrant café society of Kadıköy and the football-loving streets of Beşiktaş, it’s easy to see why travelers say that Istanbul isn’t just one city, but many cities within one." }
         
        );

    
  }

  
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }
  }
}