using System;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCuaHangVatLieuXayDung
{
    class Program
    {
        public static void Programming(ArrayList arrVatLieu)
        {
            Console.Clear();
            Menu.MenuChinh();
            int iChucNang = int.Parse(Console.ReadLine());
            switch (iChucNang)
            {
                case 0:
                    {
                        Console.Clear();
                        string strTest = "Test Nhập Số Nguyên";
                        Console.Title = strTest + " | " + Name;
                        Console.WriteLine(strTest);
                        int InRa = Input.NhapSoNguyen();
                        Console.WriteLine(InRa);
                        Console.WriteLine("Enter để tiếp tục");
                        Console.ReadLine();
                        break;
                    }
                case 1: // Tạo đối tượng
                    {
                        Console.Clear();
                        ChucNang.CreateObject(arrVatLieu);
                        break;
                    }
                case 2: // Hiện đối tượng
                    {
                        Console.Clear();
                        ChucNang.ShowObject(arrVatLieu);
                        Console.WriteLine("Enter để tiếp tục");
                        Console.ReadLine();
                        break;
                    }
                case 3: //Cập nhật đối tượng
                    {
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

        public static string Name = "Quản Lý Của Hàng Vật Liệu Xây Dựng";
        static void Main(string[] args)
        {
            // For write Vietnamese
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = Name;

            ArrayList arrVatLieu = new ArrayList();
            //Run program
            do
            {
                Programming(arrVatLieu);
            } while (true);
        }
    }
}