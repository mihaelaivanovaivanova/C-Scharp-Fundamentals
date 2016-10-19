using System;

namespace _05.TheBiggestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double big = 0.0;
            if (a >= b)
            {
                big = a;
                if (a >= c)
                {
                    big = a;
                }
                else big = c;
            }
            else if (a <= b)
            {
                big = b;
                if (b >= c)
                {
                    big = b;
                }
                else big = c;
            }
            Console.WriteLine("biggest: {0}", big);
        }
    }
}
