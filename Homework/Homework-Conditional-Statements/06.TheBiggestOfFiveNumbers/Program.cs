using System;

namespace _06.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert five numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double d = Double.Parse(Console.ReadLine());
            double e = Double.Parse(Console.ReadLine());
           if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                Console.WriteLine("Biggest: {0}",a);
            }
            else if ((b > a) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine("Biggest: {0}",b);
            }
            else if ((c > a) && (c > b) && (c > d) && (c > e))
            {
                Console.WriteLine("Biggest: {0}",c);
            }
           else if ((d > a) && (d > b) && (d > c) && (d > e))
           {
               Console.WriteLine("Biggest: {0}", d);
           }
           else //if ((e > a) && (e > b) && (e > c) && (e > d))
           {
               Console.WriteLine("Biggest: {0}", e);
           }

        }
    }
}
