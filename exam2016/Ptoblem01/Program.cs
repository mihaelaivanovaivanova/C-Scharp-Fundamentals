using System;
using System.Numerics;

namespace Ptoblem01
{
    class Program
    {
        static void Main()
        {
            long t = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());
            long s = int.Parse(Console.ReadLine());
            double n = int.Parse(Console.ReadLine());
            double totalNumberTails = t * b * s * n;
            double result1;
            double result2;
            if (totalNumberTails %2==0)
            {
                result1 = totalNumberTails * 376439;
                Console.WriteLine("{0:F3}", result1);
            }
            else
            {
                result2 = totalNumberTails / 7.0;
                Console.WriteLine("{0:F3}", result2);
            }
            

        }
    }
}
