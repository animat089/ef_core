using AnimatLabs.Infrastructure.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development;
public class MigrationDbContextFactory : IDesignTimeDbContextFactory<MigrationDbContext>
{
    protected virtual string AssemblyName {
        get => "AnimatLabs.Infrastructure.Data.DataSetup.Development";
    }
    public MigrationDbContext CreateDbContext(string[] args)
    {
        var contextOptions = new DbContextOptionsBuilder<HogwartsDbContext>().UseSqlServer(x => x.MigrationsAssembly(AssemblyName)).Options;
        return new MigrationDbContext(contextOptions);
    }
}