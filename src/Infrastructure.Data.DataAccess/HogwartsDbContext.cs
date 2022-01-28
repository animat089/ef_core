using Microsoft.EntityFrameworkCore;

namespace AnimatLabs.Infrastructure.Data.DataAccess;

/// <summary>
/// Class representing the DbContext
/// </summary>
public class HogwartsDbContext : DbContext
{
    /// <summary>
    /// Create a new instance
    /// </summary>
    /// <param name="options">Database create options</param>
    /// <returns>An instance of type <see cref="HogwartsDbContext"></returns>
    public HogwartsDbContext(DbContextOptions<HogwartsDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Do Something
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HogwartsDbContext).Assembly);
    }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Enrollment> Enrollments { get; set; }
    
    public DbSet<Student> Students { get; set; }
}