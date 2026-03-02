using Microsoft.EntityFrameworkCore;
using Pickleball_Smart.Models;

namespace Pickleball_Smart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Use singular table names and DbSet properties
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<ChiNhanh> ChiNhanh { get; set; }
        public DbSet<SanPickleball> SanPickleball { get; set; }
        public DbSet<DonDatSan> DonDatSan { get; set; }
        public DbSet<DichVuPhuTro> DichVuPhuTro { get; set; }
        public DbSet<ChiTietDichVu> ChiTietDichVu { get; set; }
        public DbSet<ThanhToan> ThanhToan { get; set; }
        public DbSet<DanhGia> DanhGia { get; set; }
        public DbSet<GhepCapAI> GhepCapAI { get; set; }
        public DbSet<LichSuChat> LichSuChat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình NguoiDung
            modelBuilder.Entity<NguoiDung>()
                .HasIndex(n => n.TenDangNhap)
                .IsUnique();

            // Cấu hình ràng buộc SoSao trong DanhGia
            modelBuilder.Entity<DanhGia>()
                .Property(d => d.SoSao)
                .HasColumnType("int");

            // Configure decimal precision to avoid truncation warnings
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.ThanhTien)
                .HasPrecision(18,2);

            modelBuilder.Entity<DichVuPhuTro>()
                .Property(e => e.Gia)
                .HasPrecision(18,2);

            modelBuilder.Entity<DonDatSan>()
                .Property(e => e.TongTien)
                .HasPrecision(18,2);

            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.SoTien)
                .HasPrecision(18,2);

            // Cấu hình All Primary Keys and table names
            modelBuilder.Entity<NguoiDung>().HasKey(e => e.NguoiDungID);
            modelBuilder.Entity<NguoiDung>().ToTable("NguoiDung");

            modelBuilder.Entity<ChiNhanh>().HasKey(e => e.ChiNhanhID);
            modelBuilder.Entity<ChiNhanh>().ToTable("ChiNhanh");

            modelBuilder.Entity<SanPickleball>().HasKey(e => e.SanID);
            modelBuilder.Entity<SanPickleball>().ToTable("SanPickleball", t => {
                t.HasCheckConstraint("CK_SanPickleball_LoaiSan", "LoaiSan IN (N'Trong nhà', N'Ngoài trời')");
                t.HasCheckConstraint("CK_SanPickleball_TrangThai", "TrangThai IN (N'Mở', N'Đóng')");
                t.HasCheckConstraint("CK_SanPickleball_GiaCoBan", "GiaCoBan >= 0");
            });
            modelBuilder.Entity<SanPickleball>()
                .HasIndex(s => new { s.TenSan, s.ChiNhanhID })
                .IsUnique(); // unique per branch

            // set column constraints
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TenSan)
                .IsRequired()
                .HasColumnType("NVARCHAR(100)");

            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.LoaiSan)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.TrangThai)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            // decimal precision for price fields
            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.GiaCoBan)
                .IsRequired()
                .HasPrecision(18,0);

            modelBuilder.Entity<SanPickleball>()
                .Property(e => e.ChiNhanhID)
                .IsRequired();

            modelBuilder.Entity<DonDatSan>().HasKey(e => e.DonDatSanID);
            modelBuilder.Entity<DonDatSan>().ToTable("DonDatSan");

            modelBuilder.Entity<DichVuPhuTro>().HasKey(e => e.DichVuID);
            modelBuilder.Entity<DichVuPhuTro>().ToTable("DichVuPhuTro");

            modelBuilder.Entity<ChiTietDichVu>().HasKey(e => e.ChiTietDichVuID);
            modelBuilder.Entity<ChiTietDichVu>().ToTable("ChiTietDichVu");

            modelBuilder.Entity<ThanhToan>().HasKey(e => e.ThanhToanID);
            modelBuilder.Entity<ThanhToan>().ToTable("ThanhToan");

            modelBuilder.Entity<DanhGia>().HasKey(e => e.DanhGiaID);
            modelBuilder.Entity<DanhGia>().ToTable("DanhGia");

            modelBuilder.Entity<GhepCapAI>().HasKey(e => e.GhepCapID);
            modelBuilder.Entity<GhepCapAI>().ToTable("GhepCapAI");

            modelBuilder.Entity<LichSuChat>().HasKey(e => e.ChatID);
            modelBuilder.Entity<LichSuChat>().ToTable("LichSuChat");
        }
    }
}
