using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public string MieuTa { get; set; }
        public decimal Gia { get; set; }   
        public int IDLoai { get; set; } 

        public Loai Loai { get; set; }
        public IList<CT_DonHang> CT_DonHangs { get; set; }
  

    }
}
