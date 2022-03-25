using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser> 
  {
    public DbSet<Tag> Treats { get; set; }
    public DbSet<Recipe> Flavors { get; set; }
    public DbSet<RecipeTag> FlavorTreat { get; set; }

    public BakeryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

