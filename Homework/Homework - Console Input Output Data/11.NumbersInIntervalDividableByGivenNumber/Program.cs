using System;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine( "Insert two numbers in increasing order: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            int secondNum = Int32.Parse(Console.ReadLine());
            int p =0;
            {
                for (int i = firstNum+1; i <secondNum; i++)
                {
                    if (i % 5 == 0)
                        p++;
                }
                Console .WriteLine (p);
                
            }
        }
    }
}
