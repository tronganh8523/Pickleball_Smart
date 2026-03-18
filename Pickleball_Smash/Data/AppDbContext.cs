using Microsoft.EntityFrameworkCore;
using Pickleball_Smash.Models;

namespace Pickleball_Smash.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<ChiNhanh> ChiNhanh { get; set; }
        public DbSet<SanPickleball> SanPickleball { get; set; }
        public DbSet<DonDatSan> DonDatSan { get; set; }
        public DbSet<DichVuPhuTro> DichVuPhuTro { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<ChiTietDichVu> ChiTietDichVu { get; set; }
        public DbSet<ThanhToan> ThanhToan { get; set; }
        public DbSet<DanhGia> DanhGia { get; set; }
        public DbSet<LichSuChat> LichSuChat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // NGUOI_DUNG
            modelBuilder.Entity<NguoiDung>().HasKey(e => e.NguoiDungID);
            modelBuilder.Entity<NguoiDung>().ToTable("NGUOI_DUNG");
            modelBuilder.Entity<NguoiDung>()
                .HasIndex(n => n.TenDangNhap)
                .IsUnique();
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap).IsRequired().HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau).IsRequired().HasColumnType("VARCHAR(255)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email).HasColumnType("VARCHAR(100)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.HoTen).HasColumnType("NVARCHAR(100)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.GioiTinh).HasColumnType("NVARCHAR(10)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT).HasColumnType("VARCHAR(15)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.VaiTro).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.NgayTao).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");

            // CHI_NHANH
            modelBuilder.Entity<ChiNhanh>().HasKey(e => e.ChiNhanhID);
            modelBuilder.Entity<ChiNhanh>().ToTable("CHI_NHANH");
            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.TenChiNhanh).IsRequired().HasColumnType("NVARCHAR(100)");
            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.DiaChi).HasColumnType("NVARCHAR(255)");
            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.SDT_LienHe).HasColumnType("VARCHAR(15)");

            // SAN_PICKLEBALL
            modelBuilder.Entity<SanPickleball>().HasKey(e => e.SanID);
            modelBuilder.Entity<SanPickleball>().ToTable("SAN_PICKLEBALL");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TenSan).HasColumnType("NVARCHAR(100)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.LoaiSan).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.MoTa).HasColumnType("NVARCHAR(MAX)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.GiaCoBan).HasPrecision(18, 2);
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TrangThai).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<SanPickleball>()
                .HasOne(e => e.ChiNhanh)
                .WithMany(e => e.SanPickleballs)
                .HasForeignKey(e => e.ChiNhanhID);

            // DICH_VU_PHU_TRO
            modelBuilder.Entity<DichVuPhuTro>().HasKey(e => e.DichVuID);
            modelBuilder.Entity<DichVuPhuTro>().ToTable("DICH_VU_PHU_TRO");
            modelBuilder.Entity<DichVuPhuTro>()
                .Property(e => e.TenDichVu).IsRequired(false).HasColumnType("NVARCHAR(100)");
            modelBuilder.Entity<DichVuPhuTro>()
                .Property(e => e.LoaiDichVu).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<DichVuPhuTro>()
                .Property(e => e.Gia).HasPrecision(18, 2);

            // VOUCHER
            modelBuilder.Entity<Voucher>().HasKey(e => e.VoucherID);
            modelBuilder.Entity<Voucher>().ToTable("VOUCHER");
            modelBuilder.Entity<Voucher>()
                .HasIndex(e => e.MaVoucher)
                .IsUnique();
            modelBuilder.Entity<Voucher>()
                .Property(e => e.MaVoucher).IsRequired().HasColumnType("VARCHAR(20)");
            modelBuilder.Entity<Voucher>()
                .Property(e => e.MoTa).HasColumnType("NVARCHAR(255)");
            modelBuilder.Entity<Voucher>()
                .Property(e => e.LoaiGiamGia).HasColumnType("NVARCHAR(20)");
            modelBuilder.Entity<Voucher>()
                .Property(e => e.GiaTriGiam).HasPrecision(18, 2);
            modelBuilder.Entity<Voucher>()
                .Property(e => e.GiamToiDa).HasPrecision(18, 2);
            modelBuilder.Entity<Voucher>()
                .Property(e => e.GiaTriDonToiThieu).HasPrecision(18, 2);
            modelBuilder.Entity<Voucher>()
                .Property(e => e.NgayBatDau).HasColumnType("DATETIME");
            modelBuilder.Entity<Voucher>()
                .Property(e => e.NgayKetThuc).HasColumnType("DATETIME");
            modelBuilder.Entity<Voucher>()
                .Property(e => e.SoLuongDaDung).HasDefaultValue(0);
            modelBuilder.Entity<Voucher>()
                .Property(e => e.TrangThai).HasColumnType("NVARCHAR(50)");

            // DON_DAT_SAN
            modelBuilder.Entity<DonDatSan>().HasKey(e => e.DonDatSanID);
            modelBuilder.Entity<DonDatSan>().ToTable("DON_DAT_SAN");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.NgayChoi).HasColumnType("date");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.ThoiGianBatDau).HasColumnType("time");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.ThoiGianKetThuc).HasColumnType("time");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.TongTien).HasPrecision(18, 2);
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.SoTienGiam).HasPrecision(18, 2).HasDefaultValue(0m);
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.TrangThaiDon).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.NgayTao).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<DonDatSan>()
                .HasOne(e => e.NguoiDung)
                .WithMany(e => e.DonDatSans)
                .HasForeignKey(e => e.NguoiDungID);
            modelBuilder.Entity<DonDatSan>()
                .HasOne(e => e.SanPickleball)
                .WithMany(e => e.DonDatSans)
                .HasForeignKey(e => e.SanID);
            modelBuilder.Entity<DonDatSan>()
                .HasOne(e => e.Voucher)
                .WithMany(e => e.DonDatSans)
                .HasForeignKey(e => e.VoucherID);

            // CHI_TIET_DICH_VU
            modelBuilder.Entity<ChiTietDichVu>().HasKey(e => e.ChiTietDichVuID);
            modelBuilder.Entity<ChiTietDichVu>().ToTable("CHI_TIET_DICH_VU");
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.ThanhTien).HasPrecision(18, 2);
            modelBuilder.Entity<ChiTietDichVu>()
                .HasOne(e => e.DonDatSan)
                .WithMany(e => e.ChiTietDichVus)
                .HasForeignKey(e => e.DonDatSanID);
            modelBuilder.Entity<ChiTietDichVu>()
                .HasOne(e => e.DichVuPhuTro)
                .WithMany(e => e.ChiTietDichVus)
                .HasForeignKey(e => e.DichVuID);

            // THANH_TOAN
            modelBuilder.Entity<ThanhToan>().HasKey(e => e.ThanhToanID);
            modelBuilder.Entity<ThanhToan>().ToTable("THANH_TOAN");
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.PhuongThuc).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.SoTien).HasPrecision(18, 2);
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.MaGiaoDich).HasColumnType("VARCHAR(100)");
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.TrangThai).HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.NgayThanhToan).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<ThanhToan>()
                .HasOne(e => e.DonDatSan)
                .WithMany(e => e.ThanhToans)
                .HasForeignKey(e => e.DonDatSanID);

            // DANH_GIA
            modelBuilder.Entity<DanhGia>().HasKey(e => e.DanhGiaID);
            modelBuilder.Entity<DanhGia>().ToTable("DANH_GIA", t =>
                t.HasCheckConstraint("CK_DANH_GIA_SoSao", "SoSao >= 1 AND SoSao <= 5"));
            modelBuilder.Entity<DanhGia>()
                .Property(d => d.SoSao).HasColumnType("int");
            modelBuilder.Entity<DanhGia>()
                .Property(e => e.NgayDanhGia).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<DanhGia>()
                .HasOne(e => e.NguoiDung)
                .WithMany(e => e.DanhGias)
                .HasForeignKey(e => e.NguoiDungID);
            modelBuilder.Entity<DanhGia>()
                .HasOne(e => e.SanPickleball)
                .WithMany(e => e.DanhGias)
                .HasForeignKey(e => e.SanID);

            // LICH_SU_CHAT
            modelBuilder.Entity<LichSuChat>().HasKey(e => e.ChatID);
            modelBuilder.Entity<LichSuChat>().ToTable("LICH_SU_CHAT");
            modelBuilder.Entity<LichSuChat>()
                .Property(e => e.ThoiGian).HasColumnType("DATETIME").HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<LichSuChat>()
                .HasOne(e => e.NguoiDung)
                .WithMany(e => e.LichSuChats)
                .HasForeignKey(e => e.NguoiDungID);
        }
    }
}

