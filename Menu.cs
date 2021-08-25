using System;

namespace QuanLyCuaHangVatLieuXayDung
{
    class Menu
    {
        public static void MenuChinh()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("| 0. Test từng phần của chương trình   |");
            Console.WriteLine("| 1. Tạo Đối Tượng Vật Liệu            |");
            Console.WriteLine("| 2. Hiện Đối Tượng Vật Liệu           |");
            Console.WriteLine("========================================");
            Console.Write("Chọn chức năng bằng số: ");
        }
        public static void MenuNhapThongTin()
        {
            Console.WriteLine("10. Chỉ Thoát và Lưu");
            Console.WriteLine("0. Thoát và xoá đối tượng ");
            Console.WriteLine("1. Nhập tên vật liệu ");
            Console.WriteLine("2. Nhập số lượng     ");
            Console.WriteLine("3. Nhập giá          ");
        }
        public static void MenuCreateObject()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("| 1. Tạo đối tượng Vật Liệu Cát        |");
            Console.WriteLine("| 2. Tạo đối tượng Vật Liệu Đá         |");
            Console.WriteLine("| 3. Tạo đối tượng Vật Liệu Ximang     |");
            Console.WriteLine("| 4. Tạo đối tượng Vật Liệu Gạch       |");
            Console.WriteLine("| 5. Tạo đối tượng Vật Liệu Sắt Thép   |");
            Console.WriteLine("| 6. Tạo đối tượng Vật Liệu Gỗ         |");
            Console.WriteLine("| 7. Tạo đối tượng Vật Liệu Thủy Tinh  |");
            Console.WriteLine("| 8. Tạo đối tượng Vật Liệu Nhựa       |");
            Console.WriteLine("| 9. Tạo đối tượng Vật Liệu Sứ         |");
            Console.WriteLine("| 0. Về Menu Chính                     |");
            Console.WriteLine("========================================");
            Console.Write("Chọn chức năng bằng số: ");
        }
        public static void MenuShow()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("| 1. Hiện Một Loại Đối Tượng           |");
            Console.WriteLine("| 2. Hiện Tất Cả Đối Tượng             |");
            Console.WriteLine("| 3. Sắp Xếp Đối Tượng                 |");
            Console.WriteLine("| 0. Về Menu Chính                     |");
            Console.WriteLine("========================================");
            Console.Write("Chọn chức năng bằng số: ");
        }
        public static void MenuShowSingleObject()
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
}