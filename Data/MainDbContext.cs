using Microsoft.EntityFrameworkCore;
using restful_api.Modals;

namespace restful_api.Data{
    public class MainDbContext : DbContext{
      public MainDbContext(DbContextOptions<MainDbContext> options):base(options)
      {
          
      }
      public DbSet<CricketModal> Cricket { get; set; }
      public DbSet<FootballModal> Soccer { get; set; }
      public DbSet<FieldHockey> Hockey { get; set; }
    }
}