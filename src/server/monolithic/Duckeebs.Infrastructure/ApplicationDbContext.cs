using Duckeebs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duckeebs.Infrastructure
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Keycap> Keycaps { get; set; }
    public DbSet<KeycapSet> KeycapSets { get; set; }

    public string DbPath { get; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source=D:\\duckeebs.db");
    }
      
  }
}
