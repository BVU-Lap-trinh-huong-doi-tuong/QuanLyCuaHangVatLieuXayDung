using System.Collections;
using QuanLyCuaHangVatLieuXayDung.LoaiVatLieu;

namespace QuanLyCuaHangVatLieuXayDung.LoaiVatLieu
{
    class Cat : VatLieu
    {
        public Cat()
        {
            setTen(" ");
            setSoLuong(0);
            setGia(0);
            setLoaiVatLieu(1);
        }
        public Cat(string Ten, int soLuong, int Gia)
        {
            setTen(Ten);
            setSoLuong(soLuong);
            setGia(Gia);
            setLoaiVatLieu(1);
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