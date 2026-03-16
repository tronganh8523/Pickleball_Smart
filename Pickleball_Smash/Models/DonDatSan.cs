namespace Pickleball_Smash.Models
{
    public class DonDatSan
    {
        public int DonDatSanID { get; set; }
        public int? NguoiDungID { get; set; }
        public int? SanID { get; set; }
        public DateTime NgayChoi { get; set; }
        public string KhungGio { get; set; } = null!;
        public decimal? TongTien { get; set; }
        public string? TrangThaiDon { get; set; }
        public DateTime NgayTao { get; set; }

        // Navigation properties
        public NguoiDung? NguoiDung { get; set; }
        public SanPickleball? SanPickleball { get; set; }
        public ICollection<ChiTietDichVu>? ChiTietDichVus { get; set; }
        public ICollection<ThanhToan>? ThanhToans { get; set; }
    }
}

