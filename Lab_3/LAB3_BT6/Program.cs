using System;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            char Kytu;
            Console.WriteLine("Nhap ky tu bat ky: ");
            Kytu = Char.Parse(Console.ReadLine());
            if (Kytu >= 'a' && Kytu <= 'z' || Kytu >= 'A' && Kytu <= 'Z')
            {
                if (Kytu == 'a' || Kytu == 'e' || Kytu == 'i' || Kytu == 'o' || Kytu == 'u' || Kytu == 'A' || Kytu == 'E' || Kytu == 'I' || Kytu == 'O' || Kytu == 'U')
                {
                    Console.WriteLine("Ky tu ban vua nhap la nguyen am");
                }
                else
                {
                    Console.WriteLine("Ky tu ban vua nhap la phu am");
                }
            }
            else
            {
                Console.WriteLine("Ky tu vua nhap khong thuoc bang chu cai Alphabet");
            }
        }
    }
}
