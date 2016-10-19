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
            string dayTime = isItBeerTime.ToString("tt");
            int hour = isItBeerTime.Hour;
            int minute = isItBeerTime.Minute;
            Console.WriteLine(dayTime);
            Console.WriteLine(hour);
            Console.WriteLine(minute );
            if ((hour > 12) || (minute > 59))
            Console.WriteLine("Invalit time format!");
            if (hour >= 1 && dayTime == "PM")
                Console.WriteLine("Beer Time");
            if (hour <= 2 && dayTime == "AM")
                Console.WriteLine("Beer Time");
            else Console.WriteLine("non-beer time");
        }
    }
}
