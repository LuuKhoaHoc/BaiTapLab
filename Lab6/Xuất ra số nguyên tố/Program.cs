using System;

namespace Lưu_Học
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [10];
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int Element in arr)
            {
                if (KT(Element)==true) {System.Console.Write( Element + " "); }     
            }
        }
       static bool KT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
