namespace Pickleball_Smash.Models
{
    public class DichVuPhuTro
    {
        public int DichVuID { get; set; }
        public string TenDichVu { get; set; } = null!;
        public string? LoaiDichVu { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuongTon { get; set; }

        // Navigation properties
        public ICollection<ChiTietDichVu>? ChiTietDichVus { get; set; }
    }
}

