namespace Pickleball_Smash.Models
{
    public class Voucher
    {
        public int VoucherID { get; set; }
        public string MaVoucher { get; set; } = null!;
        public string? MoTa { get; set; }
        public string? LoaiGiamGia { get; set; }
        public decimal? GiaTriGiam { get; set; }
        public decimal? GiamToiDa { get; set; }
        public decimal? GiaTriDonToiThieu { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? SoLuongToiDa { get; set; }
        public int? SoLuongDaDung { get; set; }
        public string? TrangThai { get; set; }

        public ICollection<DonDatSan>? DonDatSans { get; set; }
    }
}
