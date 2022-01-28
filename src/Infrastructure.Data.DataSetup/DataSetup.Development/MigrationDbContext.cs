using Microsoft.EntityFrameworkCore;

namespace DataAccess.Development;
public class MigrationContext : HogwartsDbContext
{
    public MigrationContext(DbContextOptions<HogwartsDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Skip whatever OnConfigure is doing
    }
}