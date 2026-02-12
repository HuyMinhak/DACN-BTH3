using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyCSKH.Migrations
{
    public partial class FixTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHangs_DonHang_DonHangID",
                table: "ChiTietDonHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHangs_PhanCongChamSocs_PhanCongChamSocID",
                table: "ChiTietDonHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_KhachHangs_KhachHangID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_NhanViens_NhanVienID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhanCongChamSocs_PhanCongChamSocID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongChamSocs_KhachHangs_KhachHangID",
                table: "PhanCongChamSocs");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongChamSocs_NhanViens_NhanVienID",
                table: "PhanCongChamSocs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhanCongChamSocs",
                table: "PhanCongChamSocs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDonHangs",
                table: "ChiTietDonHangs");

            migrationBuilder.RenameTable(
                name: "PhanCongChamSocs",
                newName: "PhanCongChamSoc");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "ChiTietDonHangs",
                newName: "ChiTietDonHang");

            migrationBuilder.RenameIndex(
                name: "IX_PhanCongChamSocs_NhanVienID",
                table: "PhanCongChamSoc",
                newName: "IX_PhanCongChamSoc_NhanVienID");

            migrationBuilder.RenameIndex(
                name: "IX_PhanCongChamSocs_KhachHangID",
                table: "PhanCongChamSoc",
                newName: "IX_PhanCongChamSoc_KhachHangID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHangs_PhanCongChamSocID",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_PhanCongChamSocID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHangs_DonHangID",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_DonHangID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhanCongChamSoc",
                table: "PhanCongChamSoc",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHang_DonHang_DonHangID",
                table: "ChiTietDonHang",
                column: "DonHangID",
                principalTable: "DonHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHang_PhanCongChamSoc_PhanCongChamSocID",
                table: "ChiTietDonHang",
                column: "PhanCongChamSocID",
                principalTable: "PhanCongChamSoc",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_KhachHang_KhachHangID",
                table: "DonHang",
                column: "KhachHangID",
                principalTable: "KhachHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_NhanVien_NhanVienID",
                table: "DonHang",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhanCongChamSoc_PhanCongChamSocID",
                table: "DonHang",
                column: "PhanCongChamSocID",
                principalTable: "PhanCongChamSoc",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongChamSoc_KhachHang_KhachHangID",
                table: "PhanCongChamSoc",
                column: "KhachHangID",
                principalTable: "KhachHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongChamSoc_NhanVien_NhanVienID",
                table: "PhanCongChamSoc",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHang_DonHang_DonHangID",
                table: "ChiTietDonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHang_PhanCongChamSoc_PhanCongChamSocID",
                table: "ChiTietDonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_KhachHang_KhachHangID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_NhanVien_NhanVienID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_PhanCongChamSoc_PhanCongChamSocID",
                table: "DonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongChamSoc_KhachHang_KhachHangID",
                table: "PhanCongChamSoc");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongChamSoc_NhanVien_NhanVienID",
                table: "PhanCongChamSoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhanCongChamSoc",
                table: "PhanCongChamSoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang");

            migrationBuilder.RenameTable(
                name: "PhanCongChamSoc",
                newName: "PhanCongChamSocs");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "ChiTietDonHang",
                newName: "ChiTietDonHangs");

            migrationBuilder.RenameIndex(
                name: "IX_PhanCongChamSoc_NhanVienID",
                table: "PhanCongChamSocs",
                newName: "IX_PhanCongChamSocs_NhanVienID");

            migrationBuilder.RenameIndex(
                name: "IX_PhanCongChamSoc_KhachHangID",
                table: "PhanCongChamSocs",
                newName: "IX_PhanCongChamSocs_KhachHangID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_PhanCongChamSocID",
                table: "ChiTietDonHangs",
                newName: "IX_ChiTietDonHangs_PhanCongChamSocID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_DonHangID",
                table: "ChiTietDonHangs",
                newName: "IX_ChiTietDonHangs_DonHangID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhanCongChamSocs",
                table: "PhanCongChamSocs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDonHangs",
                table: "ChiTietDonHangs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHangs_DonHang_DonHangID",
                table: "ChiTietDonHangs",
                column: "DonHangID",
                principalTable: "DonHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHangs_PhanCongChamSocs_PhanCongChamSocID",
                table: "ChiTietDonHangs",
                column: "PhanCongChamSocID",
                principalTable: "PhanCongChamSocs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_KhachHangs_KhachHangID",
                table: "DonHang",
                column: "KhachHangID",
                principalTable: "KhachHangs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_NhanViens_NhanVienID",
                table: "DonHang",
                column: "NhanVienID",
                principalTable: "NhanViens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_PhanCongChamSocs_PhanCongChamSocID",
                table: "DonHang",
                column: "PhanCongChamSocID",
                principalTable: "PhanCongChamSocs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongChamSocs_KhachHangs_KhachHangID",
                table: "PhanCongChamSocs",
                column: "KhachHangID",
                principalTable: "KhachHangs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongChamSocs_NhanViens_NhanVienID",
                table: "PhanCongChamSocs",
                column: "NhanVienID",
                principalTable: "NhanViens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
