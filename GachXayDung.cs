namespace QuanLyCuaHangVatLieuXayDung
{
    class GachXayDung : VatLieu
    {
        public GachXayDung()
        {
            setLoaiVatLieu(4);
        }
        public override string donViTinh()
        {
            return " viên";
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