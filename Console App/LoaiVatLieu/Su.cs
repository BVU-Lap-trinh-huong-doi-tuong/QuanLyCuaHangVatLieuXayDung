using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class Su : VatLieu
    {
        public Su()
        {
            setLoaiVatLieu(9);
        }
        public override string donViTinh()
        {
            return " Cây (11.7m)";
        }
        public override void NhapThongTin(ArrayList arrVatLieu)
        {
            base.NhapThongTin(arrVatLieu);
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}