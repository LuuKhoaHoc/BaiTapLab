using System;
using System.Text;

namespace Lab4_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời bạn nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================");
            long fibonaccy = 1, bonho = 0, bonho1 = 0;
            Console.WriteLine("Dãy số fibonaccy đến n là: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", fibonaccy);
                bonho1 = bonho;
                bonho = fibonaccy;
                fibonaccy = bonho + bonho1;
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}