using System;
using System.Text;

namespace baitap
{
    class Program
    {
        public static void Main()
        {
            int sum = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số n: ");
            string n = Console.ReadLine();
            
            for (int i = 0; i < n.Length; i++)
            {
                sum += (int)(n[i] - '0');
            }
            Console.WriteLine("Tổng các chữ số đến n: {0}", sum);
            Console.ReadKey();
        }
    }
}