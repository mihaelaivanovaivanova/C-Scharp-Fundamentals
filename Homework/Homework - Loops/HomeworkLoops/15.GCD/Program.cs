using System;

namespace _15.GCD
{
    class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split();
            long a = Int64.Parse(values[0]);
            long b = Int64.Parse(values[1]);
            long gcd = 1;
            for (int i=1;i<=Math.Abs(Math.Min (a, b));i++)
            {
                if(a%i==0 && b%i==0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
