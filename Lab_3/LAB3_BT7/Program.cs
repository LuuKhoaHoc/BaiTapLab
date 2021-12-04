using System;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       MENU       ");
            Console.WriteLine("==================");
            Console.WriteLine("1.  CF");
            Console.WriteLine("2.  C");
            Console.WriteLine("3.  HDJ");
            Console.WriteLine("4.  DreamWeaver");
            Console.WriteLine("5.  RDBMS");
            Console.WriteLine("6.  Learn Java By Examples");
            Console.WriteLine("==================");
            Console.Write("Chon : ");
            byte a = byte.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine(" Ban chon CF");
            }
            else if (a == 2)
            {
                Console.WriteLine(" Ban chon C");
            }
            else if (a == 3)
            {
                Console.WriteLine(" Ban chon HDJ");
            }
            else if (a == 4)
            {
                Console.WriteLine(" Ban chon DreamWeaver!");
            }
            else if (a == 5)
            {
                Console.WriteLine(" Ban chon RDBMS");
            }
            else if (a == 6)
            {
                Console.WriteLine(" Ban chon Learn Java By Examples");
            }
            else
            {
                Console.WriteLine(" Vui long chon so co trong MENU");
            }

        }
    }
}
