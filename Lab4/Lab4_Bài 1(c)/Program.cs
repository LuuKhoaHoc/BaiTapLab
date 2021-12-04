using System;

namespace Lab4_Bài_1_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập 1 số n bất kì: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("----------------------------");
            Console.Write("\n\n");
            bool a = true;
            while (n < 1)
            {
                Console.WriteLine("Mời bạn nhập lại n:");
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    a = false;
                    break;
                }

            }
            if (a)
            {
                Console.WriteLine("Số n là số nguyên tố");

            }
            else
                Console.WriteLine("Số n không phải là số nguyên tố");
            Console.ReadKey();
        }
    }
}