using System;
using System.Text;
using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung
{
    abstract class VatLieu
    {
        int loaiVatLieu;
            public void setLoaiVatLieu(int loaiVatLieu) { this.loaiVatLieu = loaiVatLieu; }
            public int getLoaiVatLieu() { return this.loaiVatLieu; }
        string Ten;
            public void setTen(string Ten) { this.Ten = Ten; }
            public string getTen() { return Ten; }
        int soLuong;
            public void setSoLuong(int soLuong) { this.soLuong = soLuong; }
            public int getSoLuong() { return soLuong; }
        int Gia;
            public int getGia()
        {
            if (Gia > 0)
            {
                return Gia;
            }
            else
            {
                return 0;
            }
        }
            public void setGia(int Gia)
        {
            if (Gia > 0)
            {
                this.Gia = Gia;
            }
            else
            {
                this.Gia = 0;
            }
        }

        public abstract string donViTinh();

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập tên: ");
            Ten = Console.ReadLine();
            Console.Write("Nhập giá: ");
            Gia = int.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            soLuong = int.Parse(Console.ReadLine());
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("Tên      :" + Ten);
            Console.WriteLine("Giá      :" + Gia);
            Console.WriteLine("Số lượng :" + soLuong);
        }
    }

    class CatXayDung : VatLieu
    {
        public CatXayDung()
        {
            setLoaiVatLieu(1);
        }
        public override string donViTinh()
        {
            return " 1m3";
        }
    }
    class DaXayDung : VatLieu
    {
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
    class XimangXayDung : VatLieu
    {
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
    class GachXayDung : VatLieu
    {
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
    class SatThepXayDung : VatLieu
    {
        int KhoiLuongTrenCay;
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
    class Go : VatLieu
    {
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
    class ThuyTinh : VatLieu
    {
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
    class Nhua : VatLieu
    {
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
    class Su : VatLieu
    {
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
    class Program
    {        
        void Programming()
        {
            ArrayList arrVatLieu = new ArrayList();
            Console.WriteLine("1. Tạo đối tượng Vật Liệu Cát");
            Console.WriteLine("2. Tạo đối tượng Vật Liệu Đá");
            Console.WriteLine("2. Tạo đối tượng Vật Liệu Ximang");
            Console.WriteLine("2. Tạo đối tượng Vật Liệu Gạch");
            Console.WriteLine("2. Tạo đối tượng Vật Liệu Đá");
            Console.WriteLine("2. Hiện thông tin đối tượng Vật Liệu Cát");

            Console.WriteLine("Chọn chức năng bằng số: ");
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 1:
                        {
                            CatXayDung catXayDung= new CatXayDung();
                            catXayDung.NhapThongTin();
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                }
            } while (iChucNang < 3);
                   }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Program program = new Program();
            program.Programming();
        }

    }
}