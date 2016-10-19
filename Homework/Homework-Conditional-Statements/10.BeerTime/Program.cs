using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert a time in hh:mm tt format:");
            DateTime isItBeerTime = DateTime.Parse(Console.ReadLine());
            int hour = isItBeerTime.Hour;
            int minute = isItBeerTime.Minute;
            string dayTime = isItBeerTime.ToString("tt");
            if ((hour >=1 && dayTime ="PM") || (hour<=2 && dayTime ="AM"))
                Console.WriteLine("Beer Time");
            else Console.WriteLine("non-beer time");
            }
    }
}
