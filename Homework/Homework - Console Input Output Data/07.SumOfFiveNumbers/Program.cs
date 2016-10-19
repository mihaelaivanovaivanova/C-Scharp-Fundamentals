using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert five numbers in a single line");
            string numbers = Console.ReadLine();
            double num1 = Convert.ToDouble(numbers.Split(' ')[0]);
            double num2 = Convert.ToDouble(numbers.Split(' ')[1]);
            double num3 = Convert.ToDouble(numbers.Split(' ')[2]);
            double num4 = Convert.ToDouble(numbers.Split(' ')[3]);
            double num5 = Convert.ToDouble(numbers.Split(' ')[4]);
            double sum = num1 +num2+num3+num4+num5;
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
