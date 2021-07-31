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
        int Gia; // Giá trên đơn vị, đơn vị của mỗi loại đối tượng có thể khác nhau.
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
                while (!Int32.TryParse(Console.ReadLine(), out Gia))
                Console.WriteLine("Invalid input! Try again"); 
                if (Gia > 0 && Gia.Equals(this.Gia))
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
            Console.Write("Nhập tên vật liệu: ");
            Ten = Console.ReadLine();
            Console.Write("Nhập giá         : ");
            Gia = Input.NhapSoNguyen();
            Console.Write("Nhập số lượng    : ");
            soLuong = Input.NhapSoNguyen();
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
    }
    class DaXayDung : VatLieu
    {
        public DaXayDung()
        {
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
    class XimangXayDung : VatLieu
    {
        public  XimangXayDung()
        {
            setLoaiVatLieu(3);
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
    class SatThepXayDung : VatLieu
    {
        int KhoiLuongTrenCay;
        public int getKhoiLuongTrenCay(){ return KhoiLuongTrenCay; }
        public void setKhoiLuongTrenCay(int KhoiLuongTrenCay){ this.KhoiLuongTrenCay = KhoiLuongTrenCay; }

        public SatThepXayDung()
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
        public Go()
        {
            setLoaiVatLieu(6);
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
    class ThuyTinh : VatLieu
    {
        public ThuyTinh()
        {
            setLoaiVatLieu(7);
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
    class Su : VatLieu
    {
        public Su()
        {
            setLoaiVatLieu(9);
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
    class Menu
    {
        public static void MenuChinh()
        {
            Console.WriteLine("0. Test từng phần của chương trình");
            Console.WriteLine("1. Tạo Đối Tượng Vật Liệu");
            Console.WriteLine("2. Hiện Đối Tượng Vật Liệu");
            Console.Write("Nhập Chức năng: ");
        }
        public static void MenuCreateObject()
        {
            Console.WriteLine("1. Tạo đối tượng Vật Liệu Cát");
            Console.WriteLine("2. Tạo đối tượng Vật Liệu Đá");
            Console.WriteLine("3. Tạo đối tượng Vật Liệu Ximang");
            Console.WriteLine("4. Tạo đối tượng Vật Liệu Gạch");
            Console.WriteLine("5. Tạo đối tượng Vật Liệu Sắt Thép");
            Console.WriteLine("6. Về Menu Chính");
            Console.Write("Chọn chức năng bằng số: ");
        }
        public static void MenuShowObject()
        {
            Console.WriteLine("1. Hiện đối tượng Vật Liệu Cát");
            Console.WriteLine("2. Hiện đối tượng Vật Liệu Đá");
            Console.WriteLine("3. Hiện đối tượng Vật Liệu Ximang");
            Console.WriteLine("4. Hiện đối tượng Vật Liệu Gạch");
            Console.WriteLine("5. Hiện đối tượng Vật Liệu Sắt Thép");
            Console.WriteLine("6. Về Menu Chính");
            Console.Write("Chọn chức năng bằng số: ");
        }
    }
    static class ChucNang
    {
        public static int ReturnNumberInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void CreateObject(ArrayList arrVatLieu)
        {
            Console.Title = "Tạo Đối Tượng Mới";
            
            Menu.MenuCreateObject();
            int iChucNang = int.Parse(Console.ReadLine());
            switch (iChucNang)
            {
                case 1:
                    {
                        Console.WriteLine("Tạo Vật Liệu Cát");
                        Console.WriteLine("Hãy Nhập Thông Tin");
                        CatXayDung catXayDung = new CatXayDung();
                        catXayDung.NhapThongTin();
                        arrVatLieu.Add(catXayDung);
                        //iSoLuongVL++;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tạo Vật Liệu Đá");
                        DaXayDung daXayDung = new DaXayDung();
                        daXayDung.NhapThongTin();
                        arrVatLieu.Add(daXayDung);
                        //iSoLuongVL++;
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tạo Vật Liệu Ximăng");
                        XimangXayDung ximangXayDung = new XimangXayDung();
                        ximangXayDung.NhapThongTin();
                        //iSoLuongVL++;
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tạo Vật Liệu Gạch");
                        GachXayDung gachXayDung = new GachXayDung();
                        gachXayDung.NhapThongTin();
                        //iSoLuongVL++;
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Vật Liệu Sắt Thép");
                        SatThepXayDung satThepXayDung = new SatThepXayDung();
                        satThepXayDung.NhapThongTin();
                        //iSoLuongVL++;
                        break;
                    }
                case 6:
                    {
                        Program.Programming(arrVatLieu);
                        break;
                    }
                default:
                    Console.WriteLine("NHập Sai Ký Tự");
                    break;
            }
        }
        static void XuatVatLieuCat(ArrayList arrVatLieu, int iThuTu)
        {
            CatXayDung cat = new CatXayDung();
            cat = (CatXayDung)arrVatLieu[iThuTu];
            if (cat.getLoaiVatLieu() == 1)
            {
                cat.XuatThongTin();
            }
        }
        public static void ShowObject(ArrayList arrVatLieu)
        {
            Menu.MenuShowObject();
            
            switch (ReturnNumberInput())
            {
                case 1:
                    {
                        Console.WriteLine("Vật Liệu Cát");
                        for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                        {
                            XuatVatLieuCat(arrVatLieu, iThuTu);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vật Liệu Đá");
                        DaXayDung daXayDung = new DaXayDung();
                        daXayDung.NhapThongTin();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Vật Liệu Ximăng");
                        XimangXayDung ximangXayDung = new XimangXayDung();
                        ximangXayDung.NhapThongTin();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Vật Liệu Gạch");
                        GachXayDung gachXayDung = new GachXayDung();
                        gachXayDung.NhapThongTin();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Vật Liệu Sắt Thép");
                        SatThepXayDung satThepXayDung = new SatThepXayDung();
                        satThepXayDung.NhapThongTin();
                        break;
                    }
                case 6:
                    {
                        Program.Programming(arrVatLieu);
                        break;
                    }
                default:
                    Console.WriteLine("NHập Sai Ký Tự");
                    break;
            }
        }
        //Chức năng chạy theo cái Menu Chính
        public static void PlayByMenuChinh(int iChucNang, ArrayList arrVatLieu)
        {
            switch (iChucNang)
            {
                case 0:
                    {
                        string strTest = "Test Nhap Số Nguyên";
                        Console.Title = strTest;
                        Console.WriteLine(strTest);
                        int InRa = Input.NhapSoNguyen();
                        Console.WriteLine(InRa);
                        break;
                    }
                case 1:
                    {
                        CreateObject(arrVatLieu);
                        break;
                    }
                case 2:
                    {
                        ShowObject(arrVatLieu);
                        break;
                    }
                default:
                    Console.WriteLine("Sai chức năng");
                    break;
            }
        }
    }
    class Input
    {
        public static int NhapSoNguyen()
        {
            int SoNguyen = int.Parse(Console.ReadLine());
            return SoNguyen;
        }
    }
    class Program
    {
        public static void Programming(ArrayList arrVatLieu)
        {
            Menu.MenuChinh();
            int iChucNang = int.Parse(Console.ReadLine());
            //int iSoLuongVL = 0;
            do
            {
                ChucNang.PlayByMenuChinh(iChucNang, arrVatLieu);
            } while (iChucNang < 3);
        }
        void CatProgram()
        {

        }

        void Help()
        {
            // Hướng Dẫn cho tạo record Cát

        }
        static void Main(string[] args)
        {
            // For write Vietnamese
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;


            ArrayList arrVatLieu = new ArrayList();
            //Run program
            Programming(arrVatLieu);
        }
    }
}