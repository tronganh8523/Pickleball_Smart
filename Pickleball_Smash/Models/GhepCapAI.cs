namespace Pickleball_Smash.Models
{
    public class GhepCapAI
    {
        public int GhepCapID { get; set; }
        public int? NguoiDungID { get; set; }
        public string? TrinhDo { get; set; }
        public string? KieuGhep { get; set; }
        public string? TrangThai { get; set; }
        public DateTime NgayTao { get; set; }

        // Navigation properties
        public NguoiDung? NguoiDung { get; set; }
    }
}

