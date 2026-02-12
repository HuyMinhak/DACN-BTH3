using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyCSKH.Migrations
{
    public partial class CapNhatCSDL_CRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiTiet_SanPhamID",
                table: "HoaDon_ChiTiet",
                column: "SanPhamID");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_ChiTiet_SanPham_SanPhamID",
                table: "HoaDon_ChiTiet",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_ChiTiet_SanPham_SanPhamID",
                table: "HoaDon_ChiTiet");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_ChiTiet_SanPhamID",
                table: "HoaDon_ChiTiet");
        }
    }
}
