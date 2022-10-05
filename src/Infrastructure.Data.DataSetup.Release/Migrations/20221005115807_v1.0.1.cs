using Infrastructure.Data.DataAccess.Core.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.DataSetup.Release.Migrations
{
    public partial class v101 : Migration
    {
        private readonly string filePath = Path.Combine("Migrations", "20221005115807_v1.0.1");

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var fileName = $"{filePath}.sql";
            migrationBuilder.Sql("SELECT @@VERSION as 'Version'");
            migrationBuilder.Sql($"EXEC(N'{File.ReadAllText(fileName).Replace("'", "''")}')");
            migrationBuilder.AddSqlFile($"{filePath}_Up.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddSqlFile($"{filePath}_Down.sql");
        }
    }
}