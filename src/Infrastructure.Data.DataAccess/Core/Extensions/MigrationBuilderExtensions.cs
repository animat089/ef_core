using Microsoft.EntityFrameworkCore.Migrations;
using System.Text.RegularExpressions;

namespace Infrastructure.Data.DataAccess.Core.Extensions
{
    public static class MigrationBuilderExtensions
    {
        public static void AddSqlFile(this MigrationBuilder migrationBuilder, string sqlFile)
        {
            var sqlContent = File.ReadAllText(sqlFile).Replace("'", "''");
            var sqlQueries = Regex.Split(sqlContent, @"\bGO\b").Select(sql => sql.Trim()).Where(sql => sql.Length > 0);
            foreach (var script in sqlQueries)
            {
                migrationBuilder.Sql($"EXEC(N'{script}')");
            }
        }
    }
}