using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore.Migrations
{
    public partial class Create_Table_NhanVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    PhongBanID = table.Column<string>(type: "TEXT", nullable: false),
                    TangLamViec = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.PhongBanID);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    TenNhanVien = table.Column<string>(type: "TEXT", nullable: false),
                    PhongBanID = table.Column<string>(type: "TEXT", nullable: true),
                    ChucVu = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.TenNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanID",
                        column: x => x.PhongBanID,
                        principalTable: "PhongBans",
                        principalColumn: "PhongBanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanID",
                table: "NhanViens",
                column: "PhongBanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
