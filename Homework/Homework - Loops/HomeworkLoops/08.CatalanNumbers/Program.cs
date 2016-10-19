using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger  chislitel = 1;
            BigInteger  znamenatel = 1;
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = n + 2, j = 1; i <= 2*n; i++, j++)
                {
                    chislitel *= i;
                    znamenatel *= j;
                }
                BigInteger result = chislitel / znamenatel / n;
                Console.WriteLine(result);
            }
        }
    }
}
