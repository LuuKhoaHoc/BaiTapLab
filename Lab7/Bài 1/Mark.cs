using System;

namespace Lab7
{
    class Mark{
            String TenMonHoc;//tên môn học
            float DiemLT;//điểm lý thuyết
            float DiemTH;//điểm thực hành
            public float DTB(){ 
                System.Console.Write("Điểm trung bình: " +( (DiemLT+DiemTH)/2 ));
                return  (DiemLT+DiemTH)/2; 
                }
            public void NhapMonHoc(){
                Console.OutputEncoding=System.Text.Encoding.UTF8;
                System.Console.Write("Tên môn học: ");
                TenMonHoc = Console.ReadLine();
                System.Console.Write("Điểm Lý Thuyết: " );
                DiemLT = float.Parse(Console.ReadLine());
                System.Console.Write("Điểm Thực Hành: " );
                DiemTH = float.Parse(Console.ReadLine());
            }
            public void XuatMonHoc(){
                System.Console.Write("Thông tin môn học \n");
                System.Console.Write("====================================\n");
                System.Console.WriteLine("Tên môn học: " +TenMonHoc);
                System.Console.WriteLine("Điểm Lý Thuyết: " +DiemLT);
                System.Console.WriteLine("Điểm Thực Hành: " + DiemTH);
                
            }
            public Mark(string TenMonHoc, float DiemLT, float DiemTH){
                this.TenMonHoc = TenMonHoc;
                this.DiemLT = DiemLT;
                this.DiemTH = DiemTH;
               
            }
        }        
    }
