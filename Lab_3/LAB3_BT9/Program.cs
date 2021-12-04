using System;

namespace BT9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toa do diem A: \n xA = ");
            float xA = float.Parse(Console.ReadLine());
            Console.Write(" yA = ");
            float yA = float.Parse(Console.ReadLine());
            Console.Write("Toa do diem B: \n xB = ");
            float xB = float.Parse(Console.ReadLine());
            Console.Write(" yB = ");
            float yB = float.Parse(Console.ReadLine());
            Console.Write("Toa do diem C: \n xC = ");
            float xC = float.Parse(Console.ReadLine());
            Console.Write(" yC = ");
            float yC = float.Parse(Console.ReadLine());
            double AB = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
            double AC = Math.Sqrt((xC - xA) * (xC - xA) + (yC - yA) * (yC - yA));
            double BC = Math.Sqrt((xC - xB) * (xC - xB) + (yC - yB) * (yC - yB));
            Console.WriteLine("Chieu dai AB = " + AB);
            Console.WriteLine("Chieu dai AC = " + AC);
            Console.WriteLine("Chieu dai BC = " + BC);
            if ((AB + AC >= BC) || (AB + BC >= AC) || (AC + BC >= AB))
            {
                if ((AB == AC) || (AB == BC) || (AC == BC))
                {
                    Console.WriteLine("Toa do 3 diem tao thanh tam giac can");
                }
                else if ((AB == AC) && (AB == BC) && (AC == BC))
                {
                    Console.WriteLine("Toa do 3 diem tao thanh tam giac deu");
                }
                else if ((AB == Math.Sqrt((BC * BC) + (AC * AC))) || (BC == Math.Sqrt((AB * AB) + (AC * AC))) || (AC == Math.Sqrt((AB * AB) + (BC * BC))))
                {
                    Console.WriteLine("Toa do 3 diem tao thanh tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Toa do 3 diem tao thanh tam giac ABC");
                }
            }
            else
            {
                Console.WriteLine("Toa do 3 diem khong tao thanh tam giac ABC");
            }


            Console.WriteLine("======================");

            Console.Write("Toa do diem D: \n xD = ");
            float xD = float.Parse(Console.ReadLine());
            Console.Write(" yD = ");
            float yD = float.Parse(Console.ReadLine());
            double sABC = 0.5 * (xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB));
            double sDAB = 0.5 * (xD * (yA - yB) + xA * (yB - yD) + xB * (yD - yA));
            double sDAC = 0.5 * (xD * (yA - yC) + xA * (yC - yD) + xC * (yD - yA));
            double sDBC = 0.5 * (xD * (yB - yC) + xB * (yC - yD) + xC * (yD - yB));
            double d = (double)((sDAB + sDAC + sDBC) - sABC);
            if (d > 0)
            {
                Console.WriteLine("Diem D nam ngoai tam giac ABC");
            }
            else if (sDAB == 0 || sDAC == 0 || sDBC == 0)
            {
                Console.WriteLine("Diem D nam tren canh tam giac ABC");
            }
            else
            {
                Console.WriteLine(" Diem D nam trong tam giac ABC");
            }




        }
    }
}
