using System;

namespace _15.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Write your birthday in (dd.mm.yyyy) format:");
            DateTime userBirthday = DateTime.Parse(Console.ReadLine());
            DateTime timeToday = DateTime.Today;
            long period = timeToday.Subtract(userBirthday).Ticks;
            int years = new DateTime(period).Year-1;
            Console.WriteLine("You are {0} years old.", years);
            int futureYears = years + 10;
            Console.WriteLine("In ten years you will be {0} years old.", futureYears);
            
        }
    }
}
