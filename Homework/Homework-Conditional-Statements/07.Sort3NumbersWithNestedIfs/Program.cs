using System;


namespace _07.Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double biggest = 0.0;
            double middle = 0.0;
            double lowest = 0.0;
            if ((a>=b) && (a>=c))
            {
                biggest = a;
                {
                    if (b>=c)
                    {
                        middle =b;
                        lowest =c;
                    }
                    else
                    {
                        middle = c;
                        lowest = b;
                    }
                
                }
            }
                if ((b>=a) && (b>=c))
            {
                biggest = b;
                {
                    if (a>=c)
                    {
                        middle =a;
                        lowest =c;
                    }
                    else
                    {
                        middle = c;
                        lowest = a;
                    }
                }
            }
                    if ((c>=b) && (c>=a))
            {
                biggest = c;
                {
                    if (b>=a)
                    {
                        middle =b;
                        lowest =a;
                    }
                    else
                    {
                        middle = a;
                        lowest = b;
                    }
                }
            }
                    Console.WriteLine("{0}, {1}, {2}", biggest , middle , lowest );
        }
    }
}
