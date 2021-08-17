namespace QuanLyCuaHangVatLieuXayDung
{
    class DaXayDung : VatLieu
    {
        public DaXayDung()
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