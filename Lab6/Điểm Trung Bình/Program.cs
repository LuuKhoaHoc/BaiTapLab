using System;

namespace Lưu_Khoa_Học
{
    class Program
    {
        static void Main(string[] args)
        {
            string HoTen;
            float diemtoan, diemvan;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            System.Console.Write("Mời bạn nhập họ và tên học sinh: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Mời bạn nhập điểm Toán: ");
            diemtoan = float.Parse(Console.ReadLine());
            System.Console.Write("Mời bạn nhập điểm Văn");
            diemvan = float.Parse(Console.ReadLine());
            System.Console.WriteLine("=======================================");
            Console.WriteLine("Điểm Trung Bình của 2 môn Toán và Văn là: {0}", DiemTrungBinh(diemtoan,diemvan) );
        }
        static float DiemTrungBinh(float diemtoan, float diemvan){
             
            return  (diemtoan + diemvan)/2;
        }
        
    }
}
