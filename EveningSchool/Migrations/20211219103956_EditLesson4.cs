using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EveningSchool.Migrations
{
    public partial class EditLesson4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Lessons",
                newName: "DateStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Lessons",
                newName: "Date");
        }
    }
}
