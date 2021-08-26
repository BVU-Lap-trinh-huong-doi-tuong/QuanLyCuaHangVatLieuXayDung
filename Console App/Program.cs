using System;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Terminal.Gui;
using NStack;


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
                        Console.Clear();
                        ChucNang.UpdateObject(arrVatLieu);
                        break;
                    }
                case 4: //Tìm đối tượng theo tên
                    {
                        Console.Clear();
                        Console.Write("Nhập từ khoá: ");
                        string keyword = Console.ReadLine();
                        ChucNang.ShowAllObject(ChucNang.SearchObject(arrVatLieu, keyword));
                        Console.ReadLine();
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
            /* Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = Name;

            ArrayList arrVatLieu = new ArrayList();
            //Run program
            do
            {
                Programming(arrVatLieu);
            } while (true);*/

            Application.Init();
            var top = Application.Top;

            /*var login = new Label("Login: ") { X = 0, Y = 0 };
            top.Add(login);*/

            // Creates the top-level window to show
            var win = new Window("MyApp")
            {
                X = 0,
                Y = 1, // Leave one row for the toplevel menu

                // By using Dim.Fill(), it will automatically resize without manual intervention
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
            top.Add(win);

            // Creates a menubar, the item "New" has a help menu.
            var menu = new MenuBar(new MenuBarItem[] {
                    new MenuBarItem ("_File", new MenuItem [] {
                        new MenuItem ("_New", "Creates new file", null),
                        new MenuItem ("_Close", "",null),
                        new MenuItem ("_Quit", "", () => { if (Quit ()) top.Running = false; })
                    }),
                    new MenuBarItem ("_Edit", new MenuItem [] {
                        new MenuItem ("_Copy", "", null),
                        new MenuItem ("C_ut", "", null),
                        new MenuItem ("_Paste", "", null)
                    })
            });
            top.Add(menu);
            Application.Run();
        }

        static bool Quit()
        {
            var n = MessageBox.Query(50, 7, "Quit Demo", "Are you sure you want to quit this demo?", "Yes", "No");
            return n == 0;
        }
    }
}