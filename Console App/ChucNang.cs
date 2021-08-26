using System;
using System.Collections;
using QuanLyCuaHangVatLieuXayDung.LoaiVatLieu;

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
        
        //Tạo Đối Tượng
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
                            Cat catXayDung = new Cat();
                            arrVatLieu.Add(catXayDung);
                            catXayDung.NhapThongTin(arrVatLieu);
                            //iSoLuongVL++;
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Title = "Tạo Vật Liệu Đá";
                            Console.WriteLine("Tạo Vật Liệu Đá");
                            Da daXayDung = new Da();
                            arrVatLieu.Add(daXayDung);
                            daXayDung.NhapThongTin(arrVatLieu);
                            //iSoLuongVL++;
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Title = "Tạo Vật Liệu Ximăng";
                            Console.WriteLine("Tạo Vật Liệu Ximăng");
                            Ximang ximangXayDung = new Ximang();
                            arrVatLieu.Add(ximangXayDung);
                            ximangXayDung.NhapThongTin(arrVatLieu);
                            //iSoLuongVL++;
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.Title = "Tạo Vật Liệu Gạch";
                            Console.WriteLine("Tạo Vật Liệu Gạch");
                            Gach gachXayDung = new Gach();
                            arrVatLieu.Add(gachXayDung);
                            gachXayDung.NhapThongTin(arrVatLieu);
                            //iSoLuongVL++;
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Sắt Thép";
                            Console.WriteLine("Vật Liệu Sắt Thép");
                            SatThep satThepXayDung = new SatThep();
                            arrVatLieu.Add(satThepXayDung);
                            satThepXayDung.NhapThongTin(arrVatLieu);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Gỗ";
                            Console.WriteLine("Vật Liệu Gỗ");
                            Go go = new Go();
                            arrVatLieu.Add(go);
                            go.NhapThongTin(arrVatLieu);
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Thủy Tinh";
                            Console.WriteLine("Vật Liệu Thủy Tinh");
                            ThuyTinh thuyTinh = new ThuyTinh();
                            arrVatLieu.Add(thuyTinh);
                            thuyTinh.NhapThongTin(arrVatLieu);
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Nhựa";
                            Console.WriteLine("Vật Liệu Nhựa");
                            Nhua nhua = new Nhua();
                            arrVatLieu.Add(nhua);
                            nhua.NhapThongTin(arrVatLieu);
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.Title = "Vật Liệu Sứ";
                            Console.WriteLine("Vật Liệu Sứ");
                            Su su = new Su();
                            arrVatLieu.Add(su);
                            su.NhapThongTin(arrVatLieu);
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
        public static void ShowSingleObject(ArrayList arrVatLieu)
        {
            do
            {
                Menu.MenuShowSingleObject();
                Console.Title = "Hiện Một Đối Tượng | " + Program.Name;
                switch (Input.NhapSoNguyen())
                {
                    case 1:
                        {
                            Console.WriteLine("Vật Liệu Cát");
                            XuatCat(arrVatLieu);
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Vật Liệu Đá");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatDa(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Vật Liệu Ximăng");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatXiMang(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Vật Liệu Gạch");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatGach(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Vật Liệu Sắt Thép");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatSatThep(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Vật Liệu Gỗ");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatGo(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Vật Liệu Thủy Tinh");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatThuyTinh(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Vật Liệu Nhựa");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatNhua(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Vật Liệu Sứ");
                            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
                            {
                                XuatSu(arrVatLieu, iThuTu);
                            }
                            Console.ReadLine();
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
        public static void ShowAllObject(ArrayList arrVatLieu)
        {
            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
            {
                Cat cat = new Cat();
                Da da = new Da();
                Ximang ximang = new Ximang();
                Gach gach = new Gach();
                SatThep satThep = new SatThep();
                Go go = new Go();
                ThuyTinh thuyTinh = new ThuyTinh();
                Nhua nhua = new Nhua();
                Su su = new Su();

                Type ia = arrVatLieu[iThuTu].GetType();
                Type iCat = cat.GetType();
                Type iDa = da.GetType();
                Type iXimang = ximang.GetType();
                Type iGach = gach.GetType();
                Type iSatThep = satThep.GetType();
                Type iGo = go.GetType();
                Type iThuyTinh = thuyTinh.GetType();
                Type iNhua = nhua.GetType();
                Type iSu = su.GetType();

                if (ia.Equals(iCat))
                {
                    cat = (Cat)arrVatLieu[iThuTu];
                    cat.XuatThongTin();
                }
                else if (ia.Equals(iDa))
                {
                    da = (Da)arrVatLieu[iThuTu];
                    da.XuatThongTin();
                }
                else if (ia.Equals(iXimang))
                {
                    ximang = (Ximang)arrVatLieu[iThuTu];
                    ximang.XuatThongTin();
                }
                else if (ia.Equals(iGach))
                {
                    gach = (Gach)arrVatLieu[iThuTu];
                    gach.XuatThongTin();
                }
                else if (ia.Equals(iSatThep))
                {
                    satThep = (SatThep)arrVatLieu[iThuTu];
                    satThep.XuatThongTin();
                }
                else if (ia.Equals(iGo))
                {
                    go = (Go)arrVatLieu[iThuTu];
                    go.XuatThongTin();
                }
                else if (ia.Equals(iThuyTinh))
                {
                    thuyTinh = (ThuyTinh)arrVatLieu[iThuTu];
                    thuyTinh.XuatThongTin();
                }
                else if (ia.Equals(iNhua))
                {
                    nhua = (Nhua)arrVatLieu[iThuTu];
                    nhua.XuatThongTin();
                }
            }

            Console.ReadLine();
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
                    case 1: //Hiện Một Loại Đối Tượng
                        {
                            ShowSingleObject(arrVatLieu);
                            break;
                        }
                    case 2: //Hiện Tất Cả Đối Tượng
                        {
                            ShowAllObject(arrVatLieu);
                            Program.Programming(arrVatLieu);
                            
                            break;
                        }
                    case 3: //Sắp Xếp Tất Cả Đối Tượng
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
        public static void UpdateObject(ArrayList arrVatLieu)
        {

        }
        public static ArrayList SearchObject(ArrayList arrVatLieu, string keyword)
        {
            ArrayList KetQua = new ArrayList();
            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
            {
                Cat cat = new Cat();
                Da da = new Da();
                Ximang ximang = new Ximang();
                Gach gach = new Gach();
                SatThep satThep = new SatThep();
                Go go = new Go();
                ThuyTinh thuyTinh = new ThuyTinh();
                Nhua nhua = new Nhua();
                Su su = new Su();

                Type ia = arrVatLieu[iThuTu].GetType();
                Type iCat = cat.GetType();
                Type iDa = da.GetType();
                Type iXimang = ximang.GetType();
                Type iGach = gach.GetType();
                Type iSatThep = satThep.GetType();
                Type iGo = go.GetType();
                Type iThuyTinh = thuyTinh.GetType();
                Type iNhua = nhua.GetType();
                Type iSu = su.GetType();
                if(ia.Equals(iCat))
                {
                    cat = (Cat)arrVatLieu[iThuTu];
                    if(cat.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(cat);
                    }
                }
                else if(ia.Equals(iDa))
                {
                    da = (Da)arrVatLieu[iThuTu];
                    if (da.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(da);
                    }
                }
                else if (ia.Equals(iXimang))
                {
                    ximang = (Ximang)arrVatLieu[iThuTu];
                    if (ximang.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(ximang);
                    }
                }
                else if (ia.Equals(iGach))
                {
                    gach = (Gach)arrVatLieu[iThuTu];
                    if (gach.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(gach);
                    }
                }
                else if (ia.Equals(iSatThep))
                {
                    satThep = (SatThep)arrVatLieu[iThuTu];
                    if (satThep.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(satThep);
                    }
                }
                else if (ia.Equals(iGo))
                {
                    go = (Go)arrVatLieu[iThuTu];
                    if (go.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(go);
                    }
                }
                else if (ia.Equals(iThuyTinh))
                {
                    thuyTinh = (ThuyTinh)arrVatLieu[iThuTu];
                    if (thuyTinh.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(thuyTinh);
                    }
                }
                else if (ia.Equals(iNhua))
                {
                    nhua = (Nhua)arrVatLieu[iThuTu];
                    if (nhua.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(nhua);
                    }
                }
                else if (ia.Equals(iSu))
                {
                    su = (Su)arrVatLieu[iThuTu];
                    if (su.getTen().ToLower().Contains(keyword.ToLower()))
                    {
                        KetQua.Add(su);
                    }
                }
            }
            return KetQua;
        }

        public static void XuatCat(ArrayList arrVatLieu)
        {
            for (int iThuTu = 0; iThuTu < arrVatLieu.Count; iThuTu++)
            {
                Cat cat = new Cat();
                Type ia = arrVatLieu[iThuTu].GetType();
                Type ib = cat.GetType();
                if (ia.Equals(ib))
                {
                    cat = (Cat)arrVatLieu[iThuTu];
                    cat.XuatThongTin();
                }
            }
        }
        public static void XuatDa(ArrayList arrVatLieu, int iThuTu)
        {
            Da da = new Da();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = da.GetType();
            if (ia.Equals(ib))
            {
                da = (Da)arrVatLieu[iThuTu];
                da.XuatThongTin();
            }
        }
        public static void XuatXiMang(ArrayList arrVatLieu, int iThuTu)
        {
            Ximang xiMang = new Ximang();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = xiMang.GetType();
            if (ia.Equals(ib))
            {
                xiMang = (Ximang)arrVatLieu[iThuTu];
                xiMang.XuatThongTin();
            }
        }
        public static void XuatGach(ArrayList arrVatLieu, int iThuTu)
        {
            Gach gach = new Gach();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = gach.GetType();
            if (ia.Equals(ib))
            {
                gach = (Gach)arrVatLieu[iThuTu];
                gach.XuatThongTin();
            }
        }
        public static void XuatSatThep(ArrayList arrVatLieu, int iThuTu)
        {
            SatThep satThep = new SatThep();
            Type ia = arrVatLieu[iThuTu].GetType();
            Type ib = satThep.GetType();
            if (ia.Equals(ib))
            {
                satThep = (SatThep)arrVatLieu[iThuTu];
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
    }
}