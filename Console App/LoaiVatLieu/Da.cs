using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class Da : VatLieu
    {
        public Da()
        {
            setTen(" ");
            setSoLuong(0);
            setGia(0);
            setLoaiVatLieu(2);
        }
        public override string donViTinh()
        {
            return " 1m3";
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