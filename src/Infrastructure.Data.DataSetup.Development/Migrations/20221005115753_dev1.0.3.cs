using Infrastructure.Data.DataAccess.Core.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.DataSetup.Development.Migrations
{
    public partial class dev103 : Migration
    {
        private readonly string filePath = Path.Combine("Migrations", "20221005115753_dev1.0.3");

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddSqlFile($"{filePath}_Up.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddSqlFile($"{filePath}_Down.sql");
        }
    }
}