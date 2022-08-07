using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.DataSetup.Release.Migrations
{
    public partial class v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("24e42ce8-6d38-4c5d-88e8-8310935bd886"),
                column: "Title",
                value: "Alchemy");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("578c9088-d00d-421f-b418-bb3e305fa32f"),
                column: "Title",
                value: "Defense Against the Dark Arts");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("680b9bd7-cae9-4126-9b22-2c700fbab340"),
                column: "Title",
                value: "Beasts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("24e42ce8-6d38-4c5d-88e8-8310935bd886"),
                column: "Title",
                value: "Course2");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("578c9088-d00d-421f-b418-bb3e305fa32f"),
                column: "Title",
                value: "Course1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: new Guid("680b9bd7-cae9-4126-9b22-2c700fbab340"),
                column: "Title",
                value: "Course3");
        }
    }
}
