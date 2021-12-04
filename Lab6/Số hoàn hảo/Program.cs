using System;

namespace Lưu_Học
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= System.Text.Encoding.UTF8;
            int[] arr = new int [10];
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write("A[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int Element in arr)
            {
                if (KT(Element)==true) {System.Console.Write("Các số hoàn hảo là " +Element );  }     
            }
        }
     static bool KT(int n)
        {
            int S = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    S += i;

            if (S == n)
                return true;
            return false;
        }
    }
}