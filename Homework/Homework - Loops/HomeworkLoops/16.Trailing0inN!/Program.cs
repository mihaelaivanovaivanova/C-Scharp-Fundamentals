using System;
using System.Numerics;

namespace _16.Trailing0inN_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int zeroCounter = 0;
            int temp;
            for (int i=5;i<= n; i+=5)
            {
                temp = i;
                while (temp % 5 == 0)
                {
                    zeroCounter++;
                    temp /= 5;
                }
            }
            Console.WriteLine(zeroCounter );
        }
    }
}
