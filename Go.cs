using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung
{
    class Go : VatLieu
    {
        public Go()
        {
            setLoaiVatLieu(6);
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