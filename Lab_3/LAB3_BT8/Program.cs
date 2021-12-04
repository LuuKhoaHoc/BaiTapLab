using System;

namespace BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("       MENU       ");
            Console.WriteLine("==================");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("x");
            Console.WriteLine(":");
            Console.WriteLine("==================");
            Console.Write("Chon: ");
            Char Chon = Char.Parse(Console.ReadLine());
            if (Chon == '+')
            {
                double c = a + b;
                Console.WriteLine("Tong: " + a + Chon + b + " = " + c);
            }
            else if (Chon == '-')
            {
                double c = a - b;
                Console.WriteLine("Hieu: " + a + Chon + b + " = " + c);
            }
            else if (Chon == 'x')
            {
                double c = a * b;
                Console.WriteLine("Tich: " + a + Chon + b + " = " + c);
            }
            else if (Chon == ':')
            {
                double c = a / b;
                Console.WriteLine("Thuong: " + a + Chon + b + " = " + c);
            }
            else
            {
                Console.WriteLine("Nhap sai phep toan \n Vui long chon cac ky tu trong MENU");
            }


        }
    }
}
