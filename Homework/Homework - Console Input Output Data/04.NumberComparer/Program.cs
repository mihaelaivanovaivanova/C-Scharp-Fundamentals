using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            //Console.WriteLine("Insert two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double greater = Math.Max(a, b);
            Console.WriteLine( greater );
        }
    }
}
