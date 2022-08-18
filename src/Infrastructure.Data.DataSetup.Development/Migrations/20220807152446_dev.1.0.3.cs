using Infrastructure.Data.DataAccess.Core.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text.RegularExpressions;

#nullable disable

namespace Infrastructure.Data.DataSetup.Development.Migrations
{
    public partial class dev103 : Migration
    {
        private string fileName =  Path.Combine("Migrations", "20220807152446_dev.1.0.3");

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
