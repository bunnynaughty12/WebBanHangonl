using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class Loai
    {
        [Key]
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }
    }
}
