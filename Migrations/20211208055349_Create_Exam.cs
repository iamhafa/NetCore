using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class Create_Exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    SubjectID = table.Column<string>(type: "TEXT", nullable: false),
                    SubjectName = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SubjectType = table.Column<string>(type: "TEXT", nullable: true),
                    Point = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.SubjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
