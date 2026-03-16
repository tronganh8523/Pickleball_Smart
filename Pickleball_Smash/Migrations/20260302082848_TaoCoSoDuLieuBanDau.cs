using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pickleball_Smash.Migrations
{
    /// <inheritdoc />
    public partial class TaoCoSoDuLieuBanDau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanh",
                columns: table => new
                {
                    ChiNhanhID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChiNhanh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SDT_LienHe = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanh", x => x.ChiNhanhID);
                });

            migrationBuilder.CreateTable(
                name: "DichVuPhuTro",
                columns: table => new
                {
                    DichVuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiDichVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVuPhuTro", x => x.DichVuID);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    NguoiDungID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.NguoiDungID);
                });

            migrationBuilder.CreateTable(
                name: "SanPickleball",
                columns: table => new
                {
                    SanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoaiSan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaCoBan = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiNhanhID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPickleball", x => x.SanID);
                    table.ForeignKey(
                        name: "FK_SanPickleball_ChiNhanh_ChiNhanhID",
                        column: x => x.ChiNhanhID,
                        principalTable: "ChiNhanh",
                        principalColumn: "ChiNhanhID");
                });

            migrationBuilder.CreateTable(
                name: "GhepCapAI",
                columns: table => new
                {
                    GhepCapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungID = table.Column<int>(type: "int", nullable: true),
                    TrinhDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KieuGhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GhepCapAI", x => x.GhepCapID);
                    table.ForeignKey(
                        name: "FK_GhepCapAI_NguoiDung_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDungID");
                });

            migrationBuilder.CreateTable(
                name: "LichSuChat",
                columns: table => new
                {
                    ChatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungID = table.Column<int>(type: "int", nullable: true),
                    NoiDungHoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanHoiAI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuChat", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_LichSuChat_NguoiDung_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDungID");
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    DanhGiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungID = table.Column<int>(type: "int", nullable: true),
                    SanID = table.Column<int>(type: "int", nullable: true),
                    SoSao = table.Column<int>(type: "int", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanPickleballSanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.DanhGiaID);
                    table.ForeignKey(
                        name: "FK_DanhGia_NguoiDung_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDungID");
                    table.ForeignKey(
                        name: "FK_DanhGia_SanPickleball_SanPickleballSanID",
                        column: x => x.SanPickleballSanID,
                        principalTable: "SanPickleball",
                        principalColumn: "SanID");
                });

            migrationBuilder.CreateTable(
                name: "DonDatSan",
                columns: table => new
                {
                    DonDatSanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungID = table.Column<int>(type: "int", nullable: true),
                    SanID = table.Column<int>(type: "int", nullable: true),
                    NgayChoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhungGio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    TrangThaiDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanPickleballSanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatSan", x => x.DonDatSanID);
                    table.ForeignKey(
                        name: "FK_DonDatSan_NguoiDung_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDung",
                        principalColumn: "NguoiDungID");
                    table.ForeignKey(
                        name: "FK_DonDatSan_SanPickleball_SanPickleballSanID",
                        column: x => x.SanPickleballSanID,
                        principalTable: "SanPickleball",
                        principalColumn: "SanID");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDichVu",
                columns: table => new
                {
                    ChiTietDichVuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonDatSanID = table.Column<int>(type: "int", nullable: true),
                    DichVuID = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    DichVuPhuTroDichVuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDichVu", x => x.ChiTietDichVuID);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_DichVuPhuTro_DichVuPhuTroDichVuID",
                        column: x => x.DichVuPhuTroDichVuID,
                        principalTable: "DichVuPhuTro",
                        principalColumn: "DichVuID");
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_DonDatSan_DonDatSanID",
                        column: x => x.DonDatSanID,
                        principalTable: "DonDatSan",
                        principalColumn: "DonDatSanID");
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    ThanhToanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonDatSanID = table.Column<int>(type: "int", nullable: true),
                    PhuongThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    MaGiaoDich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.ThanhToanID);
                    table.ForeignKey(
                        name: "FK_ThanhToan_DonDatSan_DonDatSanID",
                        column: x => x.DonDatSanID,
                        principalTable: "DonDatSan",
                        principalColumn: "DonDatSanID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_DichVuPhuTroDichVuID",
                table: "ChiTietDichVu",
                column: "DichVuPhuTroDichVuID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_DonDatSanID",
                table: "ChiTietDichVu",
                column: "DonDatSanID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_NguoiDungID",
                table: "DanhGia",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_SanPickleballSanID",
                table: "DanhGia",
                column: "SanPickleballSanID");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatSan_NguoiDungID",
                table: "DonDatSan",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatSan_SanPickleballSanID",
                table: "DonDatSan",
                column: "SanPickleballSanID");

            migrationBuilder.CreateIndex(
                name: "IX_GhepCapAI_NguoiDungID",
                table: "GhepCapAI",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuChat_NguoiDungID",
                table: "LichSuChat",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_TenDangNhap",
                table: "NguoiDung",
                column: "TenDangNhap",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPickleball_ChiNhanhID",
                table: "SanPickleball",
                column: "ChiNhanhID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPickleball_TenSan_ChiNhanhID",
                table: "SanPickleball",
                columns: new[] { "TenSan", "ChiNhanhID" },
                unique: true,
                filter: "[ChiNhanhID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_DonDatSanID",
                table: "ThanhToan",
                column: "DonDatSanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDichVu");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "GhepCapAI");

            migrationBuilder.DropTable(
                name: "LichSuChat");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "DichVuPhuTro");

            migrationBuilder.DropTable(
                name: "DonDatSan");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "SanPickleball");

            migrationBuilder.DropTable(
                name: "ChiNhanh");
        }
    }
}

