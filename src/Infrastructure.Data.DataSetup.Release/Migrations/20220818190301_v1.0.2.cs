using Infrastructure.Data.DataAccess.Core.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.DataSetup.Release.Migrations
{
    public partial class v102 : Migration
    {
        private string fileName =  Path.Combine("Migrations", "20220818190301_v1.0.2");

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddSqlFile($"{fileName}_Up.sql");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddSqlFile($"{fileName}_Down.sql");
        }
    }
}
