using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Console.OutputEncoding= System.Text.Encoding.UTF8;            
            int input(){
                return int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Demo các thao tác trên ArrayList số nguyên C#");
            System.Console.WriteLine("=============================================");
            System.Console.Write("1- Khởi tạo danh sách.\n" +
            "2- Thêm 1 phần tử vào danh sách.\n" + 
            "3- Xoá 1 phần tử ra khỏi danh sách.\n" +
            "4- Chèn 1 phần tử vào danh sách.\n" +
            "5- Duyệt danh sách.\n" +
            "6- Tìm 1 phần tử.\n" +
            "7- Sắp xếp danh sách tăng dần.\n" +
            "8- Sắp xếp danh sách giảm dần.\n" +
            "0- Thoát chương trình.\n" +
            "=============================================\n"
            );
            bool check = true;
            while ( check){
                System.Console.WriteLine();
                System.Console.Write("Bạn chọn gì: ");
            switch (Console.ReadLine())
            {
                case "2": 
                    System.Console.Write("Bạn muốn thêm phần tử nào vào danh sách: ");
                    list.Add(input());
                    break;
                case "3": 
                    System.Console.Write("Bạn muốn xoá 1 phần tử nào khỏi danh sách: ");
                    list.RemoveAt(input()); //remove at index        
                    break;
                case "4":
                    System.Console.Write("Bạn muốn chèn thêm 1 phần tử nào: ");
                    int number = input();
                    System.Console.Write($"Bạn muốn chèn{number} vào: ");
                    int index = input();
                    list.Insert(index,number);
                     break;
                case "5": 
                    System.Console.Write("Duyệt danh sách: ");
                    foreach (var item in list) //duyệt danh sách
                    {
                    Console.Write(item + " ");
                    }
                    break;
                case "6": 
                    System.Console.Write("Bạn muốn tìm phần từ nào trong danh sách: ");
                    int search = list.IndexOf(input()); //tìm kiếm 1 phần tử trong index
                    if (search == -1) System.Console.WriteLine("Not found!!");
                    else System.Console.WriteLine("In index: {0}", search);
                    break;
                case "7":
                    System.Console.Write("Sắp xếp theo thứ tự tăng dần ");
                     list.Sort(); //Sort
                    foreach (var item1 in list)
                    {
                        System.Console.WriteLine("{0} ", item1 );
                    }
                    System.Console.WriteLine("Đã sắp xếp theo thứ tự tăng dần");
                    break;
                case "8":
                    System.Console.Write("Sắp xếp theo thứ tự giảm dần ");
                    list.Sort(); list.Reverse();
                    foreach (var item in list)
                    {
                        System.Console.Write("{0} ", item);
                    }
                    System.Console.WriteLine("Đã sắp xếp theo thứ tự giảm dần");
                    break;
                case "0":
                    System.Console.Write("Bye bye!!! ");
                    check = false;
                    break;
                default:
                        System.Console.WriteLine("Mời bạn chọn lại!!!");
                        break;
            }
        }
    }
    }
}

