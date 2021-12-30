using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int input()
            {
                return int.Parse(Console.ReadLine());
            }
            var List = new List<Product>();
            System.Console.Write(
        "Chương trình quản lí danh sách sản phẩm SHOP ABC\n" +
        "=============================================\n" +
        "1- Khởi tạo danh sách.\n" +
        "2- Thêm 1 sản phẩm vào danh sách.\n" +
        "3- Xoá 1 sản phẩm ra khỏi danh sách.\n" +
        "4- Duyệt danh sách.\n" +
        "5- Tìm thông tin sản phẩm theo tên.\n" +
        "6- Tìm thông tin sản phẩm theo giá.\n" +
        "7- Tìm thông tin sản phẩm theo khoảng giá.\n" +
        "8- Sắp xếp danh sách giảm dần theo giá bán.\n" +
        "0- Thoát chương trình.\n" +
        "=============================================\n"
        );
            bool check123 = true;
            while (check123)
            {
                System.Console.WriteLine();
                System.Console.Write("Bạn chọn gì: ");
                switch (Console.ReadLine())
                {
                    case "1": //1 khởi tạo danh sách 

                        System.Console.Write("Đã khởi tạo danh sách\n");
                        break;

                    case "2": // thêm 1 sp vào danh sách    
                        Product prod = new Product();
                        System.Console.Write("Mời bạn nhập thông tin của sản phẩm\n");
                        prod.input_prod();
                        List.Add(prod);
                        break;
                    case "3":
                        System.Console.Write("Bạn muốn xoá 1 sản phẩm nào khỏi danh sách: ");
                        List.RemoveAt(input()); //remove at index        
                        break;
                    case "4": //duyet danh sach
                        foreach (var item in List)
                        {
                            item.output_prod();
                        }
                        break;

                    case "5": //tim thong tin sp theo ten
                        System.Console.Write("Mời bạn nhập tên sản phẩm cần tìm ");
                        string name = Console.ReadLine();
                        foreach (var item in List)
                        {
                            if (item.get_name() == name)
                            {
                                item.output_prod();
                            }
                        }
                        break;
                    case "6": //tim thong tin sp theo gia
                        bool check = true;
                        System.Console.Write("Mời bạn nhập giá của sản phẩm cần tìm ");
                        int price = input();
                        foreach (var item in List)
                        {
                            if (item.get_price() == price)
                            {
                                check = false;
                                System.Console.Write("Sản phẩm với giá {0} mà bạn cần tìm là {1} ", price, item.get_name());
                                item.output_prod();
                                break;
                            }
                        }

                        if (check == true)
                        {
                            System.Console.Write("Không tìm thấy giá của sản phẩm bạn vừa nhập ");
                        }
                        break;
                    case "7": //tim thong tin san pham trong khoang gia
                        System.Console.Write("Mời bạn nhập giá min: ");
                        double min = input();
                        System.Console.Write("Mời bạn nhập giá max: ");
                        double max = input();
                        bool check1 = false;
                        foreach (var item in List)
                        {
                            if (item.get_price() >= min && item.get_price() <= max)
                            {
                                item.output_prod();
                                check1 = true;
                            }
                        }
                        if (check1 == false)
                        {
                            System.Console.Write("Không có sản phẩm trong khoảng giá mà bạn cần tìm ");
                        }
                        break;
                    case "8": //sap xep danh sach giam dan theo gia ban
                        List.Sort(new Sort());
                        foreach (var item in List)
                        {
                            item.output_prod();
                        }
                        break;
                    case "0":
                        System.Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình! Hẹn gặp lại");
                        check123 = false;
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;
                }
            }
        }
    }
}
