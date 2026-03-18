using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pickleball_Smash.Migrations
{
    /// <inheritdoc />
    public partial class SyncSchemaRequested : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHI_TIET_DICH_VU_DICH_VU_PHU_TRO_DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANH_GIA_SAN_PICKLEBALL_SanPickleballSanID",
                table: "DANH_GIA");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_DAT_SAN_SAN_PICKLEBALL_SanPickleballSanID",
                table: "DON_DAT_SAN");

            migrationBuilder.DropForeignKey(
                name: "FK_SAN_PICKLEBALL_CHI_NHANH_ChiNhanhID",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropIndex(
                name: "IX_SAN_PICKLEBALL_TenSan_ChiNhanhID",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SAN_PICKLEBALL_GiaCoBan",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SAN_PICKLEBALL_LoaiSan",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SAN_PICKLEBALL_TrangThai",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropIndex(
                name: "IX_DANH_GIA_SanPickleballSanID",
                table: "DANH_GIA");

            migrationBuilder.DropIndex(
                name: "IX_CHI_TIET_DICH_VU_DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU");

            migrationBuilder.DropColumn(
                name: "SanPickleballSanID",
                table: "DANH_GIA");

            migrationBuilder.DropColumn(
                name: "DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU");

            migrationBuilder.RenameColumn(
                name: "SanPickleballSanID",
                table: "DON_DAT_SAN",
                newName: "VoucherID");

            migrationBuilder.RenameIndex(
                name: "IX_DON_DAT_SAN_SanPickleballSanID",
                table: "DON_DAT_SAN",
                newName: "IX_DON_DAT_SAN_VoucherID");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "THANH_TOAN",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhuongThuc",
                table: "THANH_TOAN",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "THANH_TOAN",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MaGiaoDich",
                table: "THANH_TOAN",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TenSan",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoaiSan",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaCoBan",
                table: "SAN_PICKLEBALL",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "ChiNhanhID",
                table: "SAN_PICKLEBALL",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VaiTro",
                table: "NGUOI_DUNG",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhap",
                table: "NGUOI_DUNG",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "NGUOI_DUNG",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "NGUOI_DUNG",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NGUOI_DUNG",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "NGUOI_DUNG",
                type: "NVARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "NGUOI_DUNG",
                type: "NVARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NGUOI_DUNG",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGian",
                table: "LICH_SU_CHAT",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThaiDon",
                table: "DON_DAT_SAN",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "DON_DAT_SAN",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "SoTienGiam",
                table: "DON_DAT_SAN",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "TenDichVu",
                table: "DICH_VU_PHU_TRO",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LoaiDichVu",
                table: "DICH_VU_PHU_TRO",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDanhGia",
                table: "DANH_GIA",
                type: "DATETIME",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "TenChiNhanh",
                table: "CHI_NHANH",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SDT_LienHe",
                table: "CHI_NHANH",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "CHI_NHANH",
                type: "NVARCHAR(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "VOUCHER",
                columns: table => new
                {
                    VoucherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaVoucher = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    MoTa = table.Column<string>(type: "NVARCHAR(255)", nullable: true),
                    LoaiGiamGia = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    GiaTriGiam = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    GiamToiDa = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    GiaTriDonToiThieu = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    SoLuongToiDa = table.Column<int>(type: "int", nullable: true),
                    SoLuongDaDung = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TrangThai = table.Column<string>(type: "NVARCHAR(50)", nullable: true, defaultValue: "Hoat dong")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VOUCHER", x => x.VoucherID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DON_DAT_SAN_SanID",
                table: "DON_DAT_SAN",
                column: "SanID");

            migrationBuilder.CreateIndex(
                name: "IX_DANH_GIA_SanID",
                table: "DANH_GIA",
                column: "SanID");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_DICH_VU_DichVuID",
                table: "CHI_TIET_DICH_VU",
                column: "DichVuID");

            migrationBuilder.CreateIndex(
                name: "IX_VOUCHER_MaVoucher",
                table: "VOUCHER",
                column: "MaVoucher",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CHI_TIET_DICH_VU_DICH_VU_PHU_TRO_DichVuID",
                table: "CHI_TIET_DICH_VU",
                column: "DichVuID",
                principalTable: "DICH_VU_PHU_TRO",
                principalColumn: "DichVuID");

            migrationBuilder.AddForeignKey(
                name: "FK_DANH_GIA_SAN_PICKLEBALL_SanID",
                table: "DANH_GIA",
                column: "SanID",
                principalTable: "SAN_PICKLEBALL",
                principalColumn: "SanID");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_DAT_SAN_SAN_PICKLEBALL_SanID",
                table: "DON_DAT_SAN",
                column: "SanID",
                principalTable: "SAN_PICKLEBALL",
                principalColumn: "SanID");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_DAT_SAN_VOUCHER_VoucherID",
                table: "DON_DAT_SAN",
                column: "VoucherID",
                principalTable: "VOUCHER",
                principalColumn: "VoucherID");

            migrationBuilder.AddForeignKey(
                name: "FK_SAN_PICKLEBALL_CHI_NHANH_ChiNhanhID",
                table: "SAN_PICKLEBALL",
                column: "ChiNhanhID",
                principalTable: "CHI_NHANH",
                principalColumn: "ChiNhanhID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHI_TIET_DICH_VU_DICH_VU_PHU_TRO_DichVuID",
                table: "CHI_TIET_DICH_VU");

            migrationBuilder.DropForeignKey(
                name: "FK_DANH_GIA_SAN_PICKLEBALL_SanID",
                table: "DANH_GIA");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_DAT_SAN_SAN_PICKLEBALL_SanID",
                table: "DON_DAT_SAN");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_DAT_SAN_VOUCHER_VoucherID",
                table: "DON_DAT_SAN");

            migrationBuilder.DropForeignKey(
                name: "FK_SAN_PICKLEBALL_CHI_NHANH_ChiNhanhID",
                table: "SAN_PICKLEBALL");

            migrationBuilder.DropTable(
                name: "VOUCHER");

            migrationBuilder.DropIndex(
                name: "IX_DON_DAT_SAN_SanID",
                table: "DON_DAT_SAN");

            migrationBuilder.DropIndex(
                name: "IX_DANH_GIA_SanID",
                table: "DANH_GIA");

            migrationBuilder.DropIndex(
                name: "IX_CHI_TIET_DICH_VU_DichVuID",
                table: "CHI_TIET_DICH_VU");

            migrationBuilder.DropColumn(
                name: "SoTienGiam",
                table: "DON_DAT_SAN");

            migrationBuilder.RenameColumn(
                name: "VoucherID",
                table: "DON_DAT_SAN",
                newName: "SanPickleballSanID");

            migrationBuilder.RenameIndex(
                name: "IX_DON_DAT_SAN_VoucherID",
                table: "DON_DAT_SAN",
                newName: "IX_DON_DAT_SAN_SanPickleballSanID");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "THANH_TOAN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhuongThuc",
                table: "THANH_TOAN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayThanhToan",
                table: "THANH_TOAN",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "MaGiaoDich",
                table: "THANH_TOAN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenSan",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MoTa",
                table: "SAN_PICKLEBALL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoaiSan",
                table: "SAN_PICKLEBALL",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaCoBan",
                table: "SAN_PICKLEBALL",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChiNhanhID",
                table: "SAN_PICKLEBALL",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VaiTro",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDangNhap",
                table: "NGUOI_DUNG",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "NGUOI_DUNG",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "NGUOI_DUNG",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGian",
                table: "LICH_SU_CHAT",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThaiDon",
                table: "DON_DAT_SAN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "DON_DAT_SAN",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "TenDichVu",
                table: "DICH_VU_PHU_TRO",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "LoaiDichVu",
                table: "DICH_VU_PHU_TRO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDanhGia",
                table: "DANH_GIA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "SanPickleballSanID",
                table: "DANH_GIA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenChiNhanh",
                table: "CHI_NHANH",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "SDT_LienHe",
                table: "CHI_NHANH",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "CHI_NHANH",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(255)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SAN_PICKLEBALL_TenSan_ChiNhanhID",
                table: "SAN_PICKLEBALL",
                columns: new[] { "TenSan", "ChiNhanhID" },
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_SAN_PICKLEBALL_GiaCoBan",
                table: "SAN_PICKLEBALL",
                sql: "GiaCoBan >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_SAN_PICKLEBALL_LoaiSan",
                table: "SAN_PICKLEBALL",
                sql: "LoaiSan IN (N'Trong nhà', N'Ngoài trời')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_SAN_PICKLEBALL_TrangThai",
                table: "SAN_PICKLEBALL",
                sql: "TrangThai IN (N'Mở', N'Đóng')");

            migrationBuilder.CreateIndex(
                name: "IX_DANH_GIA_SanPickleballSanID",
                table: "DANH_GIA",
                column: "SanPickleballSanID");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_DICH_VU_DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU",
                column: "DichVuPhuTroDichVuID");

            migrationBuilder.AddForeignKey(
                name: "FK_CHI_TIET_DICH_VU_DICH_VU_PHU_TRO_DichVuPhuTroDichVuID",
                table: "CHI_TIET_DICH_VU",
                column: "DichVuPhuTroDichVuID",
                principalTable: "DICH_VU_PHU_TRO",
                principalColumn: "DichVuID");

            migrationBuilder.AddForeignKey(
                name: "FK_DANH_GIA_SAN_PICKLEBALL_SanPickleballSanID",
                table: "DANH_GIA",
                column: "SanPickleballSanID",
                principalTable: "SAN_PICKLEBALL",
                principalColumn: "SanID");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_DAT_SAN_SAN_PICKLEBALL_SanPickleballSanID",
                table: "DON_DAT_SAN",
                column: "SanPickleballSanID",
                principalTable: "SAN_PICKLEBALL",
                principalColumn: "SanID");

            migrationBuilder.AddForeignKey(
                name: "FK_SAN_PICKLEBALL_CHI_NHANH_ChiNhanhID",
                table: "SAN_PICKLEBALL",
                column: "ChiNhanhID",
                principalTable: "CHI_NHANH",
                principalColumn: "ChiNhanhID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
