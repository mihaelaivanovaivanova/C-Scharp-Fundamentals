using System;

namespace _01.OddOrEvenIntegers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
                Console.WriteLine("odd {0}", number);
            else
                Console.WriteLine("even {0}", number);
        }
    }
}
