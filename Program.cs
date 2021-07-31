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
                this.Gia = Gia;
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
        public override void NhapThongTin()
        {
            base.NhapThongTin();

        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
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
            Console.WriteLine("========================================");
            Console.WriteLine("| 0. Test từng phần của chương trình   |");
            Console.WriteLine("| 1. Tạo Đối Tượng Vật Liệu            |");
            Console.WriteLine("| 2. Hiện Đối Tượng Vật Liệu           |");
            Console.WriteLine("========================================");
            Console.Write("Nhập Chức năng: ");
        }
        public static void MenuCreateObject()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("| 1. Tạo đối tượng Vật Liệu Cát        |");
            Console.WriteLine("| 2. Tạo đối tượng Vật Liệu Đá         |");
            Console.WriteLine("| 3. Tạo đối tượng Vật Liệu Ximang     |");
            Console.WriteLine("| 4. Tạo đối tượng Vật Liệu Gạch       |");
            Console.WriteLine("| 5. Tạo đối tượng Vật Liệu Sắt Thép   |");
            Console.WriteLine("| 6. Về Menu Chính                     |");
            Console.WriteLine("========================================");
            Console.Write("Chọn chức năng bằng số: ");
        }
        public static void MenuShowObject()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("| 1. Hiện đối tượng Vật Liệu Cát       |");
            Console.WriteLine("| 2. Hiện đối tượng Vật Liệu Đá        |");
            Console.WriteLine("| 3. Hiện đối tượng Vật Liệu Ximang    |");
            Console.WriteLine("| 4. Hiện đối tượng Vật Liệu Gạch      |");
            Console.WriteLine("| 5. Hiện đối tượng Vật Liệu Sắt Thép  |");
            Console.WriteLine("| 6. Hiện đối tượng Vật Liệu Gỗ        |");
            Console.WriteLine("| 7. Hiện đối tượng Vật Liệu Thủy Tinh |");
            Console.WriteLine("| 8. Hiện đối tượng Vật Liệu Nhựa      |");
            Console.WriteLine("| 9. Hiện đối tượng Vật Liệu Sứ        |");
            Console.WriteLine("| 0. Về Menu Chính                     |");
            Console.WriteLine("========================================");
            Console.Write("Chọn chức năng bằng số: ");
        }
    }
    static class ChucNang
    {
        public static int ReturnNumberInput()
        {
            return int.Parse(Console.ReadLine());
        }
        //Xong Tạo Đối Tượng
        public static void CreateObject(ArrayList arrVatLieu)
        {
            Console.Title = "Tạo Đối Tượng Mới | " + Program.Name;
            do
            {
                Menu.MenuCreateObject();
                int iChucNang_1 = ReturnNumberInput();
                switch (iChucNang_1)
                {
                    case 1:
                        {
                            Console.Title = "Tạo Vật Liệu Cát";
                            Console.WriteLine("Tạo Vật Liệu Cát");
                            CatXayDung catXayDung = new CatXayDung();
                            catXayDung.NhapThongTin();
                            arrVatLieu.Add(catXayDung);
                            //iSoLuongVL++;
                            break;
                        }
                    case 2:
                        {
                            Console.Title = "Tạo Vật Liệu Đá";
                            Console.WriteLine("Tạo Vật Liệu Đá");
                            DaXayDung daXayDung = new DaXayDung();
                            daXayDung.NhapThongTin();
                            arrVatLieu.Add(daXayDung);
                            //iSoLuongVL++;
                            break;
                        }
                    case 3:
                        {
                            Console.Title = "Tạo Vật Liệu Ximăng";
                            Console.WriteLine("Tạo Vật Liệu Ximăng");
                            XimangXayDung ximangXayDung = new XimangXayDung();
                            ximangXayDung.NhapThongTin();
                            arrVatLieu.Add(ximangXayDung);
                            //iSoLuongVL++;
                            break;
                        }
                    case 4:
                        {
                            Console.Title = "Tạo Vật Liệu Gạch";
                            Console.WriteLine("Tạo Vật Liệu Gạch");
                            GachXayDung gachXayDung = new GachXayDung();
                            gachXayDung.NhapThongTin();
                            arrVatLieu.Add(gachXayDung);
                            //iSoLuongVL++;
                            break;
                        }
                    case 5:
                        {
                            Console.Title = "Vật Liệu Sắt Thép";
                            Console.WriteLine("Vật Liệu Sắt Thép");
                            SatThepXayDung satThepXayDung = new SatThepXayDung();
                            satThepXayDung.NhapThongTin();
                            arrVatLieu.Add(satThepXayDung);
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
            } while (1 == 1);
        }
        
        //Xuất Đối tượng
        public static void XuatCat(ArrayList arrVatLieu, int iThuTu)
        {
            CatXayDung cat = new CatXayDung();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = cat.GetType();
            if (ia.Equals(ib))
            {
                cat = (CatXayDung)arrVatLieu[iThuTu];
                cat.XuatThongTin();
            }
        }
        public static void XuatDa(ArrayList arrVatLieu, int iThuTu)
        {
            DaXayDung da = new DaXayDung();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = da.GetType(); 
            if (ia.Equals(ib))
            {
                da = (DaXayDung)arrVatLieu[iThuTu];
                da.XuatThongTin();
            }
        }
        public static void XuatXiMang(ArrayList arrVatLieu, int iThuTu)
        {
            XimangXayDung xiMang = new XimangXayDung();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = xiMang.GetType(); 
            if (ia.Equals(ib))
            {
                xiMang = (XimangXayDung)arrVatLieu[iThuTu];
                xiMang.XuatThongTin();
            }
        }
        public static void XuatGach(ArrayList arrVatLieu, int iThuTu)
        {
            GachXayDung gach = new GachXayDung();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = gach.GetType(); 
            if (ia.Equals(ib))
            {
                gach = (GachXayDung)arrVatLieu[iThuTu];
                gach.XuatThongTin();
            }
        }
        public static void XuatSatThep(ArrayList arrVatLieu, int iThuTu)
        {
            SatThepXayDung satThep = new SatThepXayDung(); 
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = satThep.GetType();
            if (ia.Equals(ib))
            {
                satThep = (SatThepXayDung)arrVatLieu[iThuTu];
                satThep.XuatThongTin();
            }
        }
        public static void XuatGo(ArrayList arrVatLieu, int iThuTu)
        {
            Go go = new Go();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = go.GetType(); 
            if (ia.Equals(ib))
            {
                go = (Go)arrVatLieu[iThuTu];
                go.XuatThongTin();
            }
        }
        public static void XuatThuyTinh(ArrayList arrVatLieu, int iThuTu)
        {
            ThuyTinh thuyTinh = new ThuyTinh();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = thuyTinh.GetType(); 
            if (ia.Equals(ib))
            {
                thuyTinh = (ThuyTinh)arrVatLieu[iThuTu];
                thuyTinh.XuatThongTin();
            }
        }
        public static void XuatNhua(ArrayList arrVatLieu, int iThuTu)
        {
            Nhua nhua = new Nhua();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = nhua.GetType(); 
            if (ia.Equals(ib))
            {
                nhua = (Nhua)arrVatLieu[iThuTu];
                nhua.XuatThongTin();
            }
        }
        public static void XuatSu(ArrayList arrVatLieu, int iThuTu)
        {
            Su su = new Su();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = su.GetType(); 
            if (ia.Equals(ib))
            {
                su = (Su)arrVatLieu[iThuTu];
                su.XuatThongTin();
            }
        }
        
        public static void ShowObject(ArrayList arrVatLieu)
        {
            do
            {
                Menu.MenuShowObject();
                Console.Title = "Hiện Đối Tượng | " + Program.Name;
                switch (ReturnNumberInput())
                {
                    case 1:
                        {
                            Console.WriteLine("Vật Liệu Cát");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatCat(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Vật Liệu Đá");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatDa(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Vật Liệu Ximăng");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatXiMang(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Vật Liệu Gạch");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatGach(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Vật Liệu Sắt Thép");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatSatThep(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Vật Liệu Gỗ");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatGo(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Vật Liệu Thủy Tinh");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatThuyTinh(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Vật Liệu Nhựa");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatNhua(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Vật Liệu Sứ");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatSu(arrVatLieu, iThuTu);
                            }
                            break;
                        }
                    case 0:
                        {
                            Program.Programming(arrVatLieu);
                            break;
                        }
                    default:
                        Console.WriteLine("Nhập Sai Ký Tự");
                        break;
                }
            } while (1 == 1);
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
            //int iSoLuongVL = 0;
            Menu.MenuChinh();
            int iChucNang = int.Parse(Console.ReadLine());
            switch (iChucNang)
            {
                case 0:
                    {
                        string strTest = "Test Nhập Số Nguyên";
                        Console.Title = strTest + " | " + Name;
                        Console.WriteLine(strTest);
                        int InRa = Input.NhapSoNguyen();
                        Console.WriteLine(InRa);
                        break;
                    }
                case 1:
                    {
                        ChucNang.CreateObject(arrVatLieu);
                        break;
                    }
                case 2:
                    {
                        ChucNang.ShowObject(arrVatLieu);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sai chức năng");
                        break;
                    }
            }
        }
        void CatProgram()
        {

        }

        void Help()
        {
            // Hướng Dẫn cho tạo record Cát

        }
        public static string Name = "Quản Lý Của Hàng Vật Liệu Xay Dựng";
        static void Main(string[] args)
        {
            // For write Vietnamese
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = Name;

            ArrayList arrVatLieu = new ArrayList();
            //Run program
            do
            {
                Programming(arrVatLieu);
            } while (1 == 1);
        }
    }
}