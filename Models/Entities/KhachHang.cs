using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public ICollection<DonHang> DonHangs { get; set;}
    }
}
