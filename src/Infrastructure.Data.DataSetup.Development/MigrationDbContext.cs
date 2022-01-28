using Microsoft.EntityFrameworkCore;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development;
public class MigrationDbContext : HogwartsDbContext
{
    public MigrationDbContext(DbContextOptions<HogwartsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Skip whatever OnConfigure is doing
    }
}