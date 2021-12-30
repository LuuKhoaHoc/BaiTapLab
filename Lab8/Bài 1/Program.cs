using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mời bạn nhập 1 chuỗi: ");
            string input = Console.ReadLine();
            System.Console.Write("Mời bạn nhập kí tự: ");
            char kytu = char.Parse(Console.ReadLine());
            int count =0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == kytu) {
                    count++;
                }
            }
            System.Console.WriteLine("Số lần ký tự {0} xuất hiện trong chuổi là {1}", kytu, count);
        }
    }
}
