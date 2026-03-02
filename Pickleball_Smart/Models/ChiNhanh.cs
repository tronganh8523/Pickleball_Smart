namespace Pickleball_Smart.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ChiNhanh
    {
        public int ChiNhanhID { get; set; }

        [Required(ErrorMessage = "Tên chi nhánh là bắt buộc")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên chi nhánh phải có độ dài từ 3 đến 100 ký tự")]
        [Display(Name = "Tên Chi Nhánh")]
        public string TenChiNhanh { get; set; } = null!;

        [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự")]
        [Display(Name = "Địa Chỉ")]
        public string? DiaChi { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng 0 và có độ dài 10-11 số")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Số điện thoại phải có độ dài từ 10 đến 11 số")]
        [Display(Name = "Số Điện Thoại Liên Hệ")]
        public string? SDT_LienHe { get; set; }

        // Navigation properties
        public ICollection<SanPickleball>? SanPickleballs { get; set; }
    }
}
