// See https://aka.ms/new-console-template for more information
using AnimatLabs.Infrastructure.Data.DataAccess;
using Microsoft.EntityFrameworkCore;

var connectionString = "Server=localhost,1433;Initial Catalog=HogwartsDb;Integrated Security=True;";
var contextOptions = new DbContextOptionsBuilder<HogwartsDbContext>().UseSqlServer(connectionString).Options;
using var dbContext = new HogwartsDbContext(contextOptions);
    foreach(var course in dbContext.Courses)
        Console.WriteLine(course.Title);