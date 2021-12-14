using System;

namespace Lab4_Bài_2
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            System.Console.Write("Nhập 1 kí tự bất kì ");
            char n = char.Parse(Console.ReadLine());
            System.Console.Write("======================================\n");
           switch (n){
               case ((n>='a'&& n<='z')): System.Console.WriteLine("Chữ cái in thường "); break;
               case ((n>='A' && n<='Z')): System.Console.WriteLine("Chữ cái in hoa "); break;
               case ((n>='1' && n<='9')): System.Console.WriteLine("Chữ số "); break;

           }
            
                /*if (n>='a'&& n<='z') System.Console.WriteLine("Chữ cái in thường ");
                else if (n>='A' && n<='Z') System.Console.WriteLine("Chữ cái in hoa ");
                else if (n>='1' && n<='9') System.Console.WriteLine("Chữ số ");
                else System.Console.WriteLine("Kí tự đặc biệt");*/

            
            Console.ReadKey();
        }
    }
}
