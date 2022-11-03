using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ForageMvc.Models
{
  public class ForageMvcContext : IdentityDbContext<User>
  {
    public DbSet<User> User { get; set; }
    public DbSet<Card> Card { get; set; }
    public DbSet<UserCard> UserCard { get; set; }

    public ForageMvcContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Card>()
          .HasData(
            new Card {
              CardId= 1, Title= "Amateur Botanist", Type= "Score", Difficulty= "beginner", ImageUrl="css/assets/img/card1.webp", ScoreReq= 15 
            }
          );
    }
  }
}