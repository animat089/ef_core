using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimatLabs.Infrastructure.Data.DataAccess.Configurations;
public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        // Setup Defaults

        builder.Property(x => x.StudentId).HasDefaultValueSql("NEWID()");
    }
}