using System;

namespace Fibonasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= System.Text.Encoding.UTF8;        
            Console.Write("Mời bạn nhập vào điểm số của học sinh: ");
            double n = double.Parse (Console.ReadLine());
           System.Console.Write("Xếp loại học sinh là  "); QuyDoiDiem(n); 
        }
        static void QuyDoiDiem(double n)
        {
            if (n>=8.5 && n <=10){
                System.Console.WriteLine("A");            
            }           else if (n>=7){
                System.Console.WriteLine("B");
            } else if ( n >=5.5){
                System.Console.WriteLine("C");
            } else if ( n >=4){
                System.Console.WriteLine("D");
            } else if (n >=0){
                System.Console.WriteLine("F");
            }
            else System.Console.WriteLine("E");            
        }
    }
}
