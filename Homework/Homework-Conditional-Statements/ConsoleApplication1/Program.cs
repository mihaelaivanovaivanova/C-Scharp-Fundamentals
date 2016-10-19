using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a time in hh:mm tt format:");
            DateTime isItBeerTime = DateTime.Parse(Console.ReadLine());
            string timeOfTheDay = isItBeerTime.ToString("tt");
            if (isItBeerTime.Hour > 12) 
            {
                if ((isItBeerTime.Hour - 12 >= 1 && timeOfTheDay == "PM"))
                {
                    Console.WriteLine("Beer Time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }

            }
            
            else if (isItBeerTime.Hour < 12)
            {
                if (isItBeerTime.Hour < 3 && timeOfTheDay == "AM")
                {
                    Console.WriteLine("Beer Time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
                
                
           
            
        }
    }
}
    

