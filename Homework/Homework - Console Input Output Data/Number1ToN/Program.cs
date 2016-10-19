using System;


namespace Number1ToN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer number:");
            int number = Int32.Parse(Console.ReadLine());
            {
                for (int i = 1; i <= number; i++) 
                { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}
