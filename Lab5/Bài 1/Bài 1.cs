using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {        
           
            int [] arr = new int[10];
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào dãy số nguyên 10 số");
            for ( int i = 0; i < 10; i++)
            {
                Console.Write("a[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());            
            }
            System.Console.WriteLine("=====================");
            for (int i = 0; i <arr.Length ; i+=2)
            {
                Console.WriteLine("Vị trí chẵn: a[{0}] {1}",i ,arr[i]);
                

            }            
        }
    }
}
