using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Menu();
            Program.Nhap(n);
            Console.ReadKey();
        }
        static void Menu ()
        {
            System.Console.Write("+--------------------------------------------------------------------------------------+\n");
            System.Console.Write("|                                 Menu                                                 |\n");
            System.Console.Write("+--------------------------------------------------------------------------------------+\n");
            System.Console.Write("|   1. Menu 1                                                                          |\n");
            System.Console.Write("|   2. Menu 2                                                                          |\n");
            System.Console.Write("|   3. Menu 3                                                                          |\n");
            System.Console.Write("|   4. Menu 4                                                                          |\n");
            System.Console.Write("|   5. Menu 5                                                                          |\n");
            System.Console.Write("+--------------------------------------------------------------------------------------+\n");  
            System.Console.Write("           Please choose: ");
            
        }
        static void Nhap(int n)
        {
           
            do {
                     n = int.Parse(Console.ReadLine()); 
                    switch (n){
                            case 1: System.Console.WriteLine("doing Menu 1... "); break;
                            case 2: System.Console.WriteLine("doing Menu 2... "); break;
                            case 3: System.Console.WriteLine("doing Menu 3... "); break;
                            case 4: System.Console.WriteLine("doing Menu 4... "); break;
                            case 5: System.Console.WriteLine("Exiting... "); n=5; break;
                            default: Console.WriteLine("Entered incorrectly, re-enter: " + n);  break;
                    }
            }while (n != 5);
            return ;
        }
    }
}
