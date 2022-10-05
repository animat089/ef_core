using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.DataSetup.Development.Migrations
{
    public partial class dev102 : Migration
    {
        private readonly string filePath = Path.Combine("Migrations", "20221005112853_dev1.0.2");

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var fileName = $"{filePath}.sql";
            migrationBuilder.Sql("SELECT @@VERSION as 'Version'");
            migrationBuilder.Sql($"EXEC(N'{File.ReadAllText(fileName).Replace("'", "''")}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}