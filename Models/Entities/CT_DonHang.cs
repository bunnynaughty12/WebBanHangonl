namespace WebBanHang.Models.Entities
{
    public class CT_DonHang
    {
        public int IDDonHang { get; set; }
        public DonHang DonHang { get; set; }
        public int IDSanPham { get; set; }
        public SanPham SanPham { get; set; }

    }
}
