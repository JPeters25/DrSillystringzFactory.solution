using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext 
  {
    public DbSet<Engineer> Engineer { get; set; }
    public DbSet<Machine> Machine { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}