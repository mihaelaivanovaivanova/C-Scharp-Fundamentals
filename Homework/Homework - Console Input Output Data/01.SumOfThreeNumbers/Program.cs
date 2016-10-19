using System;

namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            //string numbers = Console.ReadLine();
            //double a = Convert.ToDouble(numbers.Split(' ')[0]);
            //double b = Convert.ToDouble(numbers.Split(' ')[1]);
            //double c = Convert.ToDouble(numbers.Split(' ')[2]);
            //double sum = a + b + c;
            //Console.WriteLine(sum);


            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
