using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development;
public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationContext>
{
    public MigrationContext CreateDbContext(string[] args)
    {
        var contextOptions = new DbContextOptionsBuilder<HogwartsDbContext>().UseSqlServer(x => x.MigrationsAssembly("DataAccess.Development")).Options;
        return new MigrationContext(contextOptions);
    }
}