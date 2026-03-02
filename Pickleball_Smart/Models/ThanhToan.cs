namespace Pickleball_Smart.Models
{
    public class ThanhToan
    {
        public int ThanhToanID { get; set; }
        public int? DonDatSanID { get; set; }
        public string? PhuongThuc { get; set; }
        public decimal? SoTien { get; set; }
        public string? MaGiaoDich { get; set; }
        public string? TrangThai { get; set; }
        public DateTime NgayThanhToan { get; set; }

        // Navigation properties
        public DonDatSan? DonDatSan { get; set; }
    }
}
