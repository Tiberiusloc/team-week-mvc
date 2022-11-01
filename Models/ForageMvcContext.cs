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
  }
}