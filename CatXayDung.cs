namespace QuanLyCuaHangVatLieuXayDung
{
    class CatXayDung : VatLieu
    {
        public CatXayDung()
        {
            setTen(" ");
            setSoLuong(0);
            setGia(0);
            setLoaiVatLieu(1);
        }
        public CatXayDung(string Ten, int soLuong, int Gia)
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
        public override void NhapThongTin()
        {
            base.NhapThongTin();

        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}