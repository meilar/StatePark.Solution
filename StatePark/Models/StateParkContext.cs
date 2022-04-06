using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StatePark.Models
{
  public class StateParkContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<ParkRegion> ParkRegions { get; set; }

    public StateParkContext(DbContextOptions options) : base(options) { }
  }
}