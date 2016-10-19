using System;


namespace _05.Calculate
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            int factorial = 1;
            double znamenatel = 1;
            for (int i =1; i<= n; i++)
            {
                factorial *= i;
                znamenatel = Math.Pow(x, i);
                double si = factorial/znamenatel;
                sum +=si;  
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
