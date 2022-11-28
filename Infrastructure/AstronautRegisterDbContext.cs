using Infrastructure.DatabaseObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AstronautRegisterDbContext : DbContext
{
    public AstronautRegisterDbContext(DbContextOptions<AstronautRegisterDbContext> options) : base(options)
    {
    }
    
    public DbSet<AstronautDo> Astronauts => Set<AstronautDo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<AstronautDo>()
            .HasKey(astronaut => astronaut.Id);
    }
}
