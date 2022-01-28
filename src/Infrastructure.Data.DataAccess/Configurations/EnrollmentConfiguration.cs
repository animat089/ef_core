using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development.Configurations;
public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        // Setup Defaults

        builder.Property(x => x.EnrollmentId).HasDefaultValueSql("NEWID()");

        // Setup Indexes

        builder.HasIndex(b => new { b.CourseId, b.StudentId }, "IX_Course_Student");
    }
}