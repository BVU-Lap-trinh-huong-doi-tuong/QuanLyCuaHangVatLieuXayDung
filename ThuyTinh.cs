using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung
{
    class ThuyTinh : VatLieu
    {
        public ThuyTinh()
        {
            setLoaiVatLieu(7);
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