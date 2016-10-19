using System;
using System.Numerics;


namespace _06.CalculateAgain
{
    class Program
    {
        static void Main()
        {
            uint n = UInt32.Parse(Console.ReadLine());
            uint k = UInt32.Parse(Console.ReadLine());
            BigInteger result=1;
            {
                for (uint i = k + 1; i <= n; i++)
                {
                    result *= i;
                }

                Console.WriteLine(result);
            } 
        }
    }
}
