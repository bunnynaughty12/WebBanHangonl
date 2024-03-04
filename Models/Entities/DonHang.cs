using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models.Entities
{
    public class DonHang
    {
        [Key]
        public int ID { get; set; }
        public DateTime NgayDuyet { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public int IDQuanLy {  get; set; }
        public int IDKhachHang { get; set; }

        public KhachHang KhachHang { get; set; }
        public QuanLy QuanLy { get; set; }

        public IList<CT_DonHang> CT_DonHangs { get; set; }
    }
}
