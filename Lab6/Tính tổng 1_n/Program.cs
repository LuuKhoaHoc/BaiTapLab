using System;

namespace Lưu_Khoa_Học
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            System.Console.Write("Mời bạn nhập số n: ");
            int n = int.Parse(Console.ReadLine());
            long ketqua = tong(n);
            Console.Write("Tổng các số từ 1 đến {1} là: {0}", ketqua, n);
        }
        static long tong(int n){            
        
            long s = 0;
            int i = 1;
            for ( ; i < n; i++)
            {
                s += i;
            }
                return s;
        }
    }
}

