using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class Gach : VatLieu
    {
        public Gach()
        {
            setLoaiVatLieu(4);
        }
        public override string donViTinh()
        {
            return " viên";
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