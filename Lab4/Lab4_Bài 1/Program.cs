using System;

namespace Lab4_Bài_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 1 số n bất kì: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Các số chẵn <=n là: {0}", i);
                    }
                    
                }
            }
            else
                Console.WriteLine("Mời nhập lại:"); 

            Console.ReadKey();
        }
    }
}
