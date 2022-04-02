namespace AnimatLabs.Infrastructure.Data.DataSetup.Release;
public class MigrationDbContextFactory : Development.MigrationDbContextFactory
{
    protected override string AssemblyName {
        get => "AnimatLabs.Infrastructure.Data.DataSetup.Release";
    }
}