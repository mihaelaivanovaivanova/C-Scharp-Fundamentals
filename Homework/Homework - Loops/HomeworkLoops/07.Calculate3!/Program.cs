using System;
using System.Numerics;

namespace _07.Calculate3_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger  chislitel = 1;
            BigInteger  znamenatel = 1;
            for (int i=k+1; i<= n;i++)
            {
                chislitel *= i;
            }
            for (int j = 1; j <= (n - k); j++)
            {
                znamenatel *= j;
            }
            BigInteger result =chislitel/znamenatel;
            Console.WriteLine(result);
        }
    }
}
