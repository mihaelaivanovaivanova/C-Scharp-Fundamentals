using System;


namespace _03.DevideBy7And5
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number%7==0 && number%5==0)
            {
                Console.WriteLine("true {0}",number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
            //bool devFive = (number % 5 == 0);
            //bool devSeven = (number % 7 == 0);
            //bool result = (devFive && devSeven);
           

        }
    }
}
