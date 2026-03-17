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

            // CHI_NHANH
            modelBuilder.Entity<ChiNhanh>().HasKey(e => e.ChiNhanhID);
            modelBuilder.Entity<ChiNhanh>().ToTable("CHI_NHANH");

            // SAN_PICKLEBALL
            modelBuilder.Entity<SanPickleball>().HasKey(e => e.SanID);
            modelBuilder.Entity<SanPickleball>().ToTable("SAN_PICKLEBALL", t =>
            {
                t.HasCheckConstraint("CK_SAN_PICKLEBALL_LoaiSan", "LoaiSan IN (N'Trong nhà', N'Ngoài trời')");
                t.HasCheckConstraint("CK_SAN_PICKLEBALL_TrangThai", "TrangThai IN (N'Mở', N'Đóng')");
                t.HasCheckConstraint("CK_SAN_PICKLEBALL_GiaCoBan", "GiaCoBan >= 0");
            });
            modelBuilder.Entity<SanPickleball>()
                .HasIndex(s => new { s.TenSan, s.ChiNhanhID })
                .IsUnique();
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TenSan).IsRequired().HasColumnType("NVARCHAR(100)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.LoaiSan).IsRequired().HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TrangThai).IsRequired().HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.GiaCoBan).IsRequired().HasPrecision(18, 2);
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.ChiNhanhID).IsRequired();

            // DICH_VU_PHU_TRO
            modelBuilder.Entity<DichVuPhuTro>().HasKey(e => e.DichVuID);
            modelBuilder.Entity<DichVuPhuTro>().ToTable("DICH_VU_PHU_TRO");
            modelBuilder.Entity<DichVuPhuTro>()
                .Property(e => e.Gia).HasPrecision(18, 2);

            // DON_DAT_SAN
            modelBuilder.Entity<DonDatSan>().HasKey(e => e.DonDatSanID);
            modelBuilder.Entity<DonDatSan>().ToTable("DON_DAT_SAN");
            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.TongTien).HasPrecision(18, 2);

            // CHI_TIET_DICH_VU
            modelBuilder.Entity<ChiTietDichVu>().HasKey(e => e.ChiTietDichVuID);
            modelBuilder.Entity<ChiTietDichVu>().ToTable("CHI_TIET_DICH_VU");
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.ThanhTien).HasPrecision(18, 2);

            // THANH_TOAN
            modelBuilder.Entity<ThanhToan>().HasKey(e => e.ThanhToanID);
            modelBuilder.Entity<ThanhToan>().ToTable("THANH_TOAN");
            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.SoTien).HasPrecision(18, 2);

            // DANH_GIA
            modelBuilder.Entity<DanhGia>().HasKey(e => e.DanhGiaID);
            modelBuilder.Entity<DanhGia>().ToTable("DANH_GIA", t =>
                t.HasCheckConstraint("CK_DANH_GIA_SoSao", "SoSao >= 1 AND SoSao <= 5"));
            modelBuilder.Entity<DanhGia>()
                .Property(d => d.SoSao).HasColumnType("int");

            // LICH_SU_CHAT
            modelBuilder.Entity<LichSuChat>().HasKey(e => e.ChatID);
            modelBuilder.Entity<LichSuChat>().ToTable("LICH_SU_CHAT");
        }
    }
}

