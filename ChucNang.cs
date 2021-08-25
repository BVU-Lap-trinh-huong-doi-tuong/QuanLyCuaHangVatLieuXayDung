using System;
using System.Collections;

namespace QuanLyCuaHangVatLieuXayDung
{
    static class ChucNang
    {
        public static int ReturnNumberInput()
        {
            try { 
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nhập lại nào: ");
                return int.Parse(Console.ReadLine());
            }
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
                            Console.Clear();
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
                            Console.Clear();
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
                            Console.Clear();
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
                            Console.Clear();
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
                            Console.Clear();
                            Console.Title = "Vật Liệu Sắt Thép";
                            Console.WriteLine("Vật Liệu Sắt Thép");
                            SatThepXayDung satThepXayDung = new SatThepXayDung();
                            satThepXayDung.NhapThongTin();
                            arrVatLieu.Add(satThepXayDung);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Gỗ";
                            Console.WriteLine("Vật Liệu Gỗ");
                            Go go = new Go();
                            go.NhapThongTin();
                            arrVatLieu.Add(go);
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Thủy Tinh";
                            Console.WriteLine("Vật Liệu Thủy Tinh");
                            ThuyTinh thuyTinh = new ThuyTinh();
                            thuyTinh.NhapThongTin();
                            arrVatLieu.Add(thuyTinh);
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Nhựa";
                            Console.WriteLine("Vật Liệu Nhựa");
                            Nhua nhua = new Nhua();
                            nhua.NhapThongTin();
                            arrVatLieu.Add(nhua);
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Sứ";
                            Console.WriteLine("Vật Liệu Sứ");
                            Su su = new Su();
                            su.NhapThongTin();
                            arrVatLieu.Add(su);
                            break;
                        }
                    case 0:
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
        // Sắp xếp
        //Xuất Đối tượng
        public static void XuatCat(ArrayList arrVatLieu)
        {
            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
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
        public static void ShowSingleObject(ArrayList arrVatLieu)
        {
            do
            {
                Menu.MenuShowSingleObject();
                Console.Title = "Hiện Một Đối Tượng | " + Program.Name;
                switch (ReturnNumberInput())
                {
                    case 1:
                        {
                            Console.WriteLine("Vật Liệu Cát");
                            /*for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatCat(arrVatLieu, iThuTu);
                            }
                            Task.Delay(600);*/
                            XuatCat(arrVatLieu);
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
            } while (true);
        }
        public static void ShowObject(ArrayList arrVatLieu)
        {
            do
            {
                Console.Clear();
                Menu.MenuShow();
                Console.Title = "Hiện và Sắp Xếp Đối Tượng | " + Program.Name;
                switch (ReturnNumberInput())
                {
                    case 1:
                        {
                            ShowSingleObject(arrVatLieu);
                            break;
                        }
                    case 2:
                        {
                            SapXepTheoGia(arrVatLieu);
                            Console.ReadLine();
                            break;
                        }
                    case 0:
                        {
                            Program.Programming(arrVatLieu);
                            break;
                        }
                }
            } while (true);
        }
        public static void SapXepTheoGia(ArrayList arrVatLieu)
        {
            int So = arrVatLieu.Count;
            VatLieu[] arrTam = (VatLieu[])arrVatLieu.ToArray(typeof(VatLieu));
            for (int i = 0; i < So; i++)
            {
                for (int j = i + 1; j < So; j++)
                {
                    if (arrTam[i].getGia() > arrTam[j].getGia())
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        VatLieu temp = arrTam[i];
                        arrTam[i] = arrTam[j];
                        arrTam[j] = temp;
                    }
                }
            }
            for (int i = 0; i < So; i++)
            {
                arrTam[i].XuatThongTin();
            }
        }
    
    }
}