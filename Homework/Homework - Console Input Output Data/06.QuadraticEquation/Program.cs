using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insurt three numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            //Console.WriteLine("Equation: {0}x^2+{1}x+{2}=0", a,b,c);
            double D = b * b - 4 * a * c;
            {
                if (D<0)
                {
                    Console.WriteLine("No real roots");
                }
                if (D == 0)
                {
                    double x1 = (-b) / (2 * a);
                    Console.WriteLine("x1=x2={0}", x1);
                }
                if (D>0)
                {
                    double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                    double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("{0:F2}\n{1:F2}", x1,x2);

                }
            }

        }
    }
}
