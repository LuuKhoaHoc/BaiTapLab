using System;


namespace BT3
{
     class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int Tong = 0;
            Console.Clear();
            Console.WriteLine("Nhap so thu nhat A: ?? ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai B: ??");
            B = Convert.ToInt32(Console.ReadLine());
            Tong = A + B;
            Console.WriteLine("Tong cua " + A + " Va " + B + " La " + Tong);
            Console.ReadLine();
        }
    }
}
