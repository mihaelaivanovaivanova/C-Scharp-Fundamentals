using System;


namespace _01.ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert two numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            {
                if (a>b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                Console.WriteLine("{0} {1}",a,b);
            }
        }
    }
}
