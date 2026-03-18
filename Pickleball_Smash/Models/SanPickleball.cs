namespace Pickleball_Smash.Models
{
    public class SanPickleball
    {
        public int SanID { get; set; }
        public string? TenSan { get; set; }
        public string? LoaiSan { get; set; }
        public string? MoTa { get; set; }
        public decimal? GiaCoBan { get; set; }
        public string? TrangThai { get; set; }
        public int? ChiNhanhID { get; set; }

        // Navigation properties
        public ChiNhanh? ChiNhanh { get; set; }
        public ICollection<DonDatSan>? DonDatSans { get; set; }
        public ICollection<DanhGia>? DanhGias { get; set; }
    }
}

