﻿namespace QuanLyCuaHangVatLieuXayDung
{
    class Nhua : VatLieu
    {
        public Nhua()
        {
            setLoaiVatLieu(8);
        }
        public override string donViTinh()
        {
            return " Cây (11.7m)";
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