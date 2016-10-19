using System;


namespace _04.MultiplicationSIgn
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers:");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            if ((a>0 && b>0 && c>0) ||(a>0 && b<0 && c<0) ||(a<0 && b<0 && c>0) ||(a<0 && b>0 && c<0))
            {
                Console.WriteLine("result: +");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("result: 0");
            }
            else
                Console.WriteLine("result: -");
        }
    }
}
