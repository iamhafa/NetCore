using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class Remove_Validation_Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "TEXT",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "TEXT",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");
        }
    }
}
