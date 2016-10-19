using System;


namespace _09.SumOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer number: ");
            long n = long.Parse(Console.ReadLine());
            decimal sum = 0.0m;
            decimal number = 0;
            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Sum: {0:F2}",sum);
        }
    }
}
