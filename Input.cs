using System;

namespace QuanLyCuaHangVatLieuXayDung
{
    class Input
    {
        public static int NhapSoNguyen()
        {
            int SoNguyen = 0;
            try
            {
                SoNguyen = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Chỉ nhập số");
                SoNguyen = int.Parse(Console.ReadLine());
            }
            return SoNguyen;
        }
    }
}