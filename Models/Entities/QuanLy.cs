using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class QuanLy
    {
        [Key]
        public int ID { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }

        public ICollection<DonHang> DonHangss { get; set; }
       
    }
}
