using System;


namespace _09.ExchaneValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("{0} {1}", a, b);
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
