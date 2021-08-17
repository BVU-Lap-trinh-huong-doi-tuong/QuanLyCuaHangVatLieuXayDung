namespace QuanLyCuaHangVatLieuXayDung
{
    class XimangXayDung : VatLieu
    {
        public XimangXayDung()
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