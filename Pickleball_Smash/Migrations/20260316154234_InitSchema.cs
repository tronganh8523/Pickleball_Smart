using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pickleball_Smash.Migrations
{
    /// <inheritdoc />
    public partial class InitSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHI_NHANH",
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
                    table.PrimaryKey("PK_CHI_NHANH", x => x.ChiNhanhID);
                });

            migrationBuilder.CreateTable(
                name: "DICH_VU_PHU_TRO",
                columns: table => new
                {
                    DichVuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiDichVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DICH_VU_PHU_TRO", x => x.DichVuID);
                });

            migrationBuilder.CreateTable(
                name: "NGUOI_DUNG",
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
                    table.PrimaryKey("PK_NGUOI_DUNG", x => x.NguoiDungID);
                });

            migrationBuilder.CreateTable(
                name: "SAN_PICKLEBALL",
                columns: table => new
                {
                    SanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSan = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    LoaiSan = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaCoBan = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TrangThai = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    ChiNhanhID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAN_PICKLEBALL", x => x.SanID);
                    table.CheckConstraint("CK_SAN_PICKLEBALL_GiaCoBan", "GiaCoBan >= 0");
                    table.CheckConstraint("CK_SAN_PICKLEBALL_LoaiSan", "LoaiSan IN (N'Trong nhà', N'Ngoài trời')");
                    table.CheckConstraint("CK_SAN_PICKLEBALL_TrangThai", "TrangThai IN (N'Mở', N'Đóng')");
                    table.ForeignKey(
                        name: "FK_SAN_PICKLEBALL_CHI_NHANH_ChiNhanhID",
                        column: x => x.ChiNhanhID,
                        principalTable: "CHI_NHANH",
                        principalColumn: "ChiNhanhID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LICH_SU_CHAT",
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
                    table.PrimaryKey("PK_LICH_SU_CHAT", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_LICH_SU_CHAT_NGUOI_DUNG_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "NguoiDungID");
                });

            migrationBuilder.CreateTable(
                name: "DANH_GIA",
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
                    table.PrimaryKey("PK_DANH_GIA", x => x.DanhGiaID);
                    table.CheckConstraint("CK_DANH_GIA_SoSao", "SoSao >= 1 AND SoSao <= 5");
                    table.ForeignKey(
                        name: "FK_DANH_GIA_NGUOI_DUNG_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "NguoiDungID");
                    table.ForeignKey(
                        name: "FK_DANH_GIA_SAN_PICKLEBALL_SanPickleballSanID",
                        column: x => x.SanPickleballSanID,
                        principalTable: "SAN_PICKLEBALL",
                        principalColumn: "SanID");
                });

            migrationBuilder.CreateTable(
                name: "DON_DAT_SAN",
                columns: table => new
                {
                    DonDatSanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguoiDungID = table.Column<int>(type: "int", nullable: true),
                    SanID = table.Column<int>(type: "int", nullable: true),
                    NgayChoi = table.Column<DateOnly>(type: "date", nullable: false),
                    ThoiGianBatDau = table.Column<TimeOnly>(type: "time", nullable: false),
                    ThoiGianKetThuc = table.Column<TimeOnly>(type: "time", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    TrangThaiDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanPickleballSanID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DON_DAT_SAN", x => x.DonDatSanID);
                    table.ForeignKey(
                        name: "FK_DON_DAT_SAN_NGUOI_DUNG_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "NguoiDungID");
                    table.ForeignKey(
                        name: "FK_DON_DAT_SAN_SAN_PICKLEBALL_SanPickleballSanID",
                        column: x => x.SanPickleballSanID,
                        principalTable: "SAN_PICKLEBALL",
                        principalColumn: "SanID");
                });

            migrationBuilder.CreateTable(
                name: "CHI_TIET_DICH_VU",
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
                    table.PrimaryKey("PK_CHI_TIET_DICH_VU", x => x.ChiTietDichVuID);
                    table.ForeignKey(
                        name: "FK_CHI_TIET_DICH_VU_DICH_VU_PHU_TRO_DichVuPhuTroDichVuID",
                        column: x => x.DichVuPhuTroDichVuID,
                        principalTable: "DICH_VU_PHU_TRO",
                        principalColumn: "DichVuID");
                    table.ForeignKey(
                        name: "FK_CHI_TIET_DICH_VU_DON_DAT_SAN_DonDatSanID",
                        column: x => x.DonDatSanID,
                        principalTable: "DON_DAT_SAN",
                        principalColumn: "DonDatSanID");
                });

            migrationBuilder.CreateTable(
                name: "THANH_TOAN",
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
                    table.PrimaryKey("PK_THANH_TOAN", x => x.ThanhToanID);
                    table.ForeignKey(
                        name: "FK_THANH_TOAN_DON_DAT_SAN_DonDatSanID",
                        column: x => x.DonDatSanID,
                        principalTable: "DON_DAT_SAN",
                        principalColumn: "DonDatSanID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_DICH_VU_DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU",
                column: "DichVuPhuTroDichVuID");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_DICH_VU_DonDatSanID",
                table: "CHI_TIET_DICH_VU",
                column: "DonDatSanID");

            migrationBuilder.CreateIndex(
                name: "IX_DANH_GIA_NguoiDungID",
                table: "DANH_GIA",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_DANH_GIA_SanPickleballSanID",
                table: "DANH_GIA",
                column: "SanPickleballSanID");

            migrationBuilder.CreateIndex(
                name: "IX_DON_DAT_SAN_NguoiDungID",
                table: "DON_DAT_SAN",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_DON_DAT_SAN_SanPickleballSanID",
                table: "DON_DAT_SAN",
                column: "SanPickleballSanID");

            migrationBuilder.CreateIndex(
                name: "IX_LICH_SU_CHAT_NguoiDungID",
                table: "LICH_SU_CHAT",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_NGUOI_DUNG_TenDangNhap",
                table: "NGUOI_DUNG",
                column: "TenDangNhap",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SAN_PICKLEBALL_ChiNhanhID",
                table: "SAN_PICKLEBALL",
                column: "ChiNhanhID");

            migrationBuilder.CreateIndex(
                name: "IX_SAN_PICKLEBALL_TenSan_ChiNhanhID",
                table: "SAN_PICKLEBALL",
                columns: new[] { "TenSan", "ChiNhanhID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_THANH_TOAN_DonDatSanID",
                table: "THANH_TOAN",
                column: "DonDatSanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHI_TIET_DICH_VU");

            migrationBuilder.DropTable(
                name: "DANH_GIA");

            migrationBuilder.DropTable(
                name: "LICH_SU_CHAT");

            migrationBuilder.DropTable(
                name: "THANH_TOAN");

            migrationBuilder.DropTable(
                name: "DICH_VU_PHU_TRO");

            migrationBuilder.DropTable(
                name: "DON_DAT_SAN");

            migrationBuilder.DropTable(
                name: "NGUOI_DUNG");

            migrationBuilder.DropTable(
                name: "SAN_PICKLEBALL");

            migrationBuilder.DropTable(
                name: "CHI_NHANH");
        }
    }
}
