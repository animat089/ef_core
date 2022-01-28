using AnimatLabs.Infrastructure.Data.DataSetup.Development;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Release;
public class MigrationDbContextFactory : DataSetup.Development.MigrationDbContextFactory
{
    protected override string AssemblyName {
        get => "AnimatLabs.Infrastructure.Data.DataSetup.Release";
    }
}