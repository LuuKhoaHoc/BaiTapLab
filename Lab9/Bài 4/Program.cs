using System;
using System.Collections;
using System.Collections.Generic;

namespace Bài_4
{
    class Program{
 static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            
            var List = new List<Student>();
                System.Console.Write(
            "Chương trình quản lí danh sách sinh viên sử dụng ArrayList\n" +
            "=============================================\n" +
            "1- Khởi tạo danh sách.\n" +
            "2- Thêm 1 sinh viên vào danh sách.\n" + 
            "3- Duyệt danh sách.\n" +
            "4- Tìm thông tin sinh viên theo tên sinh viên.\n" +
            "5- Sửa điểm cho sinh viên.\n" +
            "6- Danh sách sinh viên được nhận học bổng.\n" +
            "7- Xem điểm sinh viên.\n" +
            "8- Sắp xếp danh sách giảm dần theo ĐTB.\n" +
            "9- Sắp xếp danh sách giảm dần theo ĐTB, tăng dẩn theo tên.\n" +
            "0- Thoát chương trình.\n" +
            "=============================================\n"
            );
            bool check123 = true;
            while ( check123){
                System.Console.WriteLine();
                System.Console.Write("Bạn chọn gì: ");
            switch (Console.ReadLine())
                {
                    case "1": //1 khởi tạo danh sách 
                        
                        System.Console.Write("Đã khởi tạo danh sách\n");
                        break;

                    case "2": // thêm 1 sv vào danh sách    
                        Student sv = new Student();
                        System.Console.Write("Mời bạn nhập thông tin của sinh viên\n");
                        sv.input_student();
                        List.Add(sv);
                        break;

                    case "3": //duyet danh sach
                        foreach (var item in List)
                        {
                        item.output_student();
                        }
                        break;

                    case "4": //tim thong tin sv theo ten
                        System.Console.Write("Mời bạn nhập tên sinh viên cần tìm ");
                        string name = Console.ReadLine();
                        foreach (var item in List)
                        {
                            if (item.get_name() == name)
                            {
                                item.output_student();
                            }
                        }
                        break;
                    case "5": //sua diem cho sinh vien
                        bool check = true;
                        System.Console.Write("Mời bạn nhập mã số sinh viên cần sửa điểm ");
                        string code = Console.ReadLine();
                        
                        foreach (var item in List)
                        {
                            if (item.get_code() == code)
                            {
                                 check = false;
                                System.Console.Write("Sinh viên {0} ({1}) có số điểm cần sửa là: ", item.get_name(),item.get_code());
                                item.set_mark(float.Parse(Console.ReadLine()));
                               break;
                            } 
                        }
                        
                        if (check==true)
                        {
                            System.Console.Write("Không tìm thấy mã sinh viên bạn vừa nhập ");
                        }
                        break;    
                    case "6": //danh sách sinh viên đc nhận học bổng
                        System.Console.Write("Những sinh viên nhận được học bỗng là: ");
                        bool check1 = false;
                        foreach (var item in List)
                        {
                            if (item.check_scholarship() ==true)
                            {
                                System.Console.WriteLine(item.get_name());
                                check1 = true;
                                
                            }
                            }
                        if (check1==false)
                        {
                             System.Console.Write("Không có sinh viên nhận được học bỗng ");
                        }
                        break;  
                    case "7": //xem điểm
                        bool check2 = false;
                        System.Console.Write("Mời bạn nhập mã số sinh viên xem điểm ");
                        string code1 = Console.ReadLine();                        
                        foreach (var item in List)
                        {
                            if (item.get_code() == code1)
                            {
                                System.Console.WriteLine("Điểm sinh viên {0} là {1}", item.get_name(), item.get_mark());                    
                                check2 = true;
                                
                            } 
                        }
                        if (check2==false)
                        {
                            System.Console.Write("Không tìm thấy mã sinh viên bạn vừa nhập ");
                        }
                        break;  
                    case "8": //sắp xếp giảm dần theo DTB của sinh viên
                        List.Sort(new SortByMark());
                        foreach (var item in List)
                        {
                            item.output_student();
                        }
                        break;  
                    case "9": //sắp xếp danh sách giảm dần theo điểm trung bình, nếu điểm trung bình bằng nhau thì tăng dần theo tên sinh viên
                        List.Sort(new SortByMarkName());
                        foreach (var item in List)
                        {
                            item.output_student();
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