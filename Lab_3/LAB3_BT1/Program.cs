using System;

namespace Lab3_BaiTapReNhanh
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap vao a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao b = ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            { Console.WriteLine("Error: divided by zero"); }
            else
            {
                float c = (float)a / b;
                Console.WriteLine("C = " + c);

            }
            Console.ReadKey();
        }
    }
}
