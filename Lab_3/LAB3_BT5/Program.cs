using System;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B;
            Console.WriteLine("So km = ");
            A = float.Parse(Console.ReadLine());
            if (A <= 1)
            {
                B = 15000;
                Console.WriteLine("Tong tien taxi la: " + B + "d");
            }
            else if (A <= 5)
            {
                Console.WriteLine("Tong tien taxi la: " + (A * 15000) + "d");
            }
            else if (A <= 120)
            {
                Console.WriteLine("Tong tien taxi la: " + (A * 11000) + "d");
            }
            else
            {
                B = A * 15000;
                Console.WriteLine("Tong tien taxi la: " + (B - ((B / 100) * 10) + "d"));
            }
        }
    }
}
