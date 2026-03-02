namespace Pickleball_Smart.Models
{
    public class ChiTietDichVu
    {
        public int ChiTietDichVuID { get; set; }
        public int? DonDatSanID { get; set; }
        public int? DichVuID { get; set; }
        public int? SoLuong { get; set; }
        public decimal? ThanhTien { get; set; }

        // Navigation properties
        public DonDatSan? DonDatSan { get; set; }
        public DichVuPhuTro? DichVuPhuTro { get; set; }
    }
}
