using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert radius: ");
            double r = Double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            perimeter = System.Math.Round(perimeter,2);
            double area = Math.PI * r * r;
            area=System .Math .Round (area , 2);
            Console.WriteLine("Perimether: {0}\nArea: {1}", perimeter, area);

        }
    }
}
