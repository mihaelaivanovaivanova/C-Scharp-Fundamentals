using System;


namespace _13.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            //decimal a = decimal.Parse(Console.ReadLine());
            //decimal b = decimal.Parse(Console.ReadLine());
            //decimal eps = Math.Abs(a - b);
            //Console.WriteLine(eps);
            //Console.WriteLine(eps < 0.000001m);

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = Math.Abs(a - b);
            Console.WriteLine(eps);
            Console.WriteLine(eps < 0.000001);
        }
    }
}
