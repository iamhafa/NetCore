using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class Edit_Exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "Point",
                table: "Exams",
                newName: "StudentName");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PointOfStudent",
                table: "Exams",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "PointOfStudent",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Exams",
                newName: "Point");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
