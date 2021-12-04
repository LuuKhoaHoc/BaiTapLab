using System;

namespace Lab3_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 4.3f, b = 2, c = 5.7f, d = 8;

            if (a > b)
            {
                {
                    if (a > c)

                    {
                        if (a > d)
                        {
                            Console.WriteLine("max = " + a + " min = " + b);
                        }
                        else
                        {
                            Console.WriteLine("max = " + d + " min = " + b);
                        }
                    }
                    else
                    {
                        if (c > d)
                        {
                            Console.WriteLine("max = " + c + " min = " + b);
                        }
                        else
                        {
                            Console.WriteLine("max = " + d + " min = " + b);
                        }
                    }
                }
            }

            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("max = " + b + " min = " + a);
                    }
                    else
                    {
                        Console.WriteLine("max = " + d + " min = " + a);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("max = " + c + " min = " + a);
                    }
                    else
                    {
                        Console.WriteLine("max = " + d + " min = " + a);
                    }
                }

            }
        }
    }
}
