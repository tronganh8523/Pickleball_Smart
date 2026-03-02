namespace Pickleball_Smart.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SanPickleball
    {
        public int SanID { get; set; }

        [Required(ErrorMessage = "Tên sân là bắt buộc")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên sân phải có độ dài 3-100 ký tự")]
        public string TenSan { get; set; } = null!;

        [Required(ErrorMessage = "Loại sân là bắt buộc")]
        [RegularExpression("^(Trong nhà|Ngoài trời)$", ErrorMessage = "Loại sân không hợp lệ")] 
        public string LoaiSan { get; set; } = null!;
        public string? MoTa { get; set; }

        [Required(ErrorMessage = "Giá cơ bản là bắt buộc")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải >= 0")]
        public decimal GiaCoBan { get; set; }

        [Required(ErrorMessage = "Trạng thái sân là bắt buộc")]
        [RegularExpression("^(Đóng|Mở)$", ErrorMessage = "Trạng thái không hợp lệ")]
        public string TrangThai { get; set; } = null!;
        [Required(ErrorMessage = "Chi nhánh là bắt buộc")]
        public int ChiNhanhID { get; set; }

        // Navigation properties
        public ChiNhanh? ChiNhanh { get; set; }
        public ICollection<DonDatSan>? DonDatSans { get; set; }
        public ICollection<DanhGia>? DanhGias { get; set; }
    }
}
