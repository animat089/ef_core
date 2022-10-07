// See https://aka.ms/new-console-template for more information
using AnimatLabs.Infrastructure.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

var connectionString = "Server=localhost;Initial Catalog=HogwartsDb;Integrated Security=True;";
var migrationAssemblyName = "AnimatLabs.Infrastructure.Data.DataSetup.Release";
var contextOptions = new DbContextOptionsBuilder<HogwartsDbContext>().UseSqlServer(
    connectionString, x => x.MigrationsAssembly(migrationAssemblyName)).Options;
using (var dbContext = new HogwartsDbContext(contextOptions))
{
    dbContext.Database.Migrate();
    Console.WriteLine("All Courses from EF Model:");
    foreach (var course in dbContext.Courses)
        Console.WriteLine(course.Title);

    Console.WriteLine("All Courses from Stored Proc:");
    foreach (var course in dbContext.Courses.FromSqlRaw("GetAllCourses"))
        Console.WriteLine(course.Title);
}