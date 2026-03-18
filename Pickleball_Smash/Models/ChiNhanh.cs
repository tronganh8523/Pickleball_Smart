namespace Pickleball_Smash.Models
{
    public class ChiNhanh
    {
        public int ChiNhanhID { get; set; }
        public string TenChiNhanh { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? SDT_LienHe { get; set; }

        // Navigation properties
        public ICollection<SanPickleball>? SanPickleballs { get; set; }
    }
}

