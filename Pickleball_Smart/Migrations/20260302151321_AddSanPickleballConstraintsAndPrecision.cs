using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pickleball_Smart.Migrations
{
    /// <inheritdoc />
    public partial class AddSanPickleballConstraintsAndPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPickleball_ChiNhanh_ChiNhanhID",
                table: "SanPickleball");

            migrationBuilder.DropIndex(
                name: "IX_SanPickleball_TenSan_ChiNhanhID",
                table: "SanPickleball");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "SanPickleball",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenSan",
                table: "SanPickleball",
                type: "NVARCHAR(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LoaiSan",
                table: "SanPickleball",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaCoBan",
                table: "SanPickleball",
                type: "decimal(18,0)",
                precision: 18,
                scale: 0,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChiNhanhID",
                table: "SanPickleball",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPickleball_TenSan_ChiNhanhID",
                table: "SanPickleball",
                columns: new[] { "TenSan", "ChiNhanhID" },
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_SanPickleball_GiaCoBan",
                table: "SanPickleball",
                sql: "GiaCoBan >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_SanPickleball_LoaiSan",
                table: "SanPickleball",
                sql: "LoaiSan IN (N'Trong nhà', N'Ngoài trời')");

            migrationBuilder.AddCheckConstraint(
                name: "CK_SanPickleball_TrangThai",
                table: "SanPickleball",
                sql: "TrangThai IN (N'Mở', N'Đóng')");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPickleball_ChiNhanh_ChiNhanhID",
                table: "SanPickleball",
                column: "ChiNhanhID",
                principalTable: "ChiNhanh",
                principalColumn: "ChiNhanhID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPickleball_ChiNhanh_ChiNhanhID",
                table: "SanPickleball");

            migrationBuilder.DropIndex(
                name: "IX_SanPickleball_TenSan_ChiNhanhID",
                table: "SanPickleball");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SanPickleball_GiaCoBan",
                table: "SanPickleball");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SanPickleball_LoaiSan",
                table: "SanPickleball");

            migrationBuilder.DropCheckConstraint(
                name: "CK_SanPickleball_TrangThai",
                table: "SanPickleball");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "SanPickleball",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TenSan",
                table: "SanPickleball",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LoaiSan",
                table: "SanPickleball",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaCoBan",
                table: "SanPickleball",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18,
                oldScale: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ChiNhanhID",
                table: "SanPickleball",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SanPickleball_TenSan_ChiNhanhID",
                table: "SanPickleball",
                columns: new[] { "TenSan", "ChiNhanhID" },
                unique: true,
                filter: "[ChiNhanhID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPickleball_ChiNhanh_ChiNhanhID",
                table: "SanPickleball",
                column: "ChiNhanhID",
                principalTable: "ChiNhanh",
                principalColumn: "ChiNhanhID");
        }
    }
}
