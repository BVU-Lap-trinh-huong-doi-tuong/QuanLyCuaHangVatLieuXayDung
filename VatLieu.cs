using System;
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

        public virtual void NhapThongTin(ArrayList arrVatLieu)
        {
            do
            {
                Menu.MenuNhapThongTin();
                int iChucNang = Input.NhapSoNguyen();
                switch (iChucNang)
                {
                    case 0: //Thoát và xoá Đối Tượng
                        {
                            arrVatLieu.RemoveAt(arrVatLieu.Count);
                            Program.Programming(arrVatLieu);
                            break;
                        }
                    case 1: // Nhập tên vật liệu
                        {
                            Console.Write("Nhập tên vật liệu: ");
                            Ten = Console.ReadLine();
                            break;
                        }
                    case 2: // Nhập giá
                        {
                            Console.Write("Nhập giá         : ");
                            Gia = Input.NhapSoNguyen();
                            break;
                        }
                    case 3: // Nhập số lượng
                        {
                            Console.Write("Nhập số lượng    : ");
                            soLuong = Input.NhapSoNguyen();
                            break;
                        }
                    case 10: //Thoát và Lưu Đối Tượng
                        {
                            Program.Programming(arrVatLieu);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ!");
                            break;
                        }
                }
            }while (true);
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("Tên      :" + Ten);
            Console.WriteLine("Giá      :" + Gia);
            Console.WriteLine("Số lượng :" + soLuong);
        }
    }
}