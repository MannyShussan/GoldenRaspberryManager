using Microsoft.EntityFrameworkCore;

namespace GoldenRaspberryAwards.Infrastructure.Data;

public class GoldenRaspberryAwardsContext : DbContext
{
    public GoldenRaspberryAwardsContext(DbContextOptions<GoldenRaspberryAwardsContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
