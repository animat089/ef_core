using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimatLabs.Infrastructure.Data.DataSetup.Development.Configurations;
public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        // Setup Defaults

        builder.Property(x => x.CourseId).HasDefaultValueSql("NEWID()");

        // Setup Master Data

        builder.HasData(
            new Course() { CourseId = new Guid("578C9088-D00D-421F-B418-BB3E305FA32F"), Credits = 5, Title = "Course1", Year = 1 },
            new Course() { CourseId = new Guid("24E42CE8-6D38-4C5D-88E8-8310935BD886"), Credits = 2, Title = "Course2", Year = 2 },
            new Course() { CourseId = new Guid("680B9BD7-CAE9-4126-9B22-2C700FBAB340"), Credits = 3, Title = "Course3", Year = 3 });
    }
}