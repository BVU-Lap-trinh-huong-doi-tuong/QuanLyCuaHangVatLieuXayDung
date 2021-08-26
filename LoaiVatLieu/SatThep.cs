using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class SatThep : VatLieu
    {
        int KhoiLuongTrenCay;
        public int getKhoiLuongTrenCay(){ return KhoiLuongTrenCay; }
        public void setKhoiLuongTrenCay(int KhoiLuongTrenCay){ this.KhoiLuongTrenCay = KhoiLuongTrenCay; }

        public SatThep()
        {
            setTen(" ");
            setSoLuong(0);
            setGia(0);
            setKhoiLuongTrenCay(0);
            setLoaiVatLieu(5);
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