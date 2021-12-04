using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap canh thu nhat: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu hai: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu ba: ");
            c = float.Parse(Console.ReadLine());
            if (a + b >= c || a + c >= b || b + c >= a)
            {
                Console.WriteLine(" Day la 3 canh cua tam giac");
            }
            else
            {
                Console.WriteLine(" Day khong phai la 3 canh cua tam giac");
            }

        }
    }
}
