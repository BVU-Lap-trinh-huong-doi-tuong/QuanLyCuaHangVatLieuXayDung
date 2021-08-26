using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class Ximang : VatLieu
    {
        public Ximang()
        {
            setLoaiVatLieu(2);
            setSoLuong(0);
            setGia(0);
            setLoaiVatLieu(2);
        }
        public override string donViTinh()
        {
            return " bao";
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