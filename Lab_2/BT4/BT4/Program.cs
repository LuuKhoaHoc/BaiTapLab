using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a: ");
            float a= float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            float b = float.Parse(Console.ReadLine());
            float x = -b/a;
            Console.WriteLine("{0}x + {1} = 0 \n =>x= {2}",a,b,x);
            Console.ReadKey();
        }
    }
}
