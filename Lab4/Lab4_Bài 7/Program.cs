using System;
using System.Threading.Channels;

namespace Lab4_Bài_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=2, count=0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mời bạn nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("======================");
            Console.WriteLine("\n");
            while (count < n)
            {
                if (check(number))
                { 
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }
        }

        static Boolean check(int number)
        {
            bool check = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}


