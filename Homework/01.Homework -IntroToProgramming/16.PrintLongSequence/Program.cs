using System;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}, ", i * (-1));
                }
            }
        }
    }
}
