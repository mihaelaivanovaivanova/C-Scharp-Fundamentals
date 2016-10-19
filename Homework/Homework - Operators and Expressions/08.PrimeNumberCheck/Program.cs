using System;


namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            if (number <= 1)
            {
                Console.WriteLine("false");
            }
            else if (number == 2 || number == 3)
            {
                Console.WriteLine("true");
            }
            else if (number >3)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number %i ==0)
                    {
                       count ++;
                                          
                    }
                }
                if (count == 0)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }

        }
    }
}
