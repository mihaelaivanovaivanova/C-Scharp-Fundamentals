using System;


namespace Problem01
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int nextDay = day + 1;
            if ((month ==4||month ==6||month==9||month==11)&&nextDay ==31)
            {
                nextDay=1;
                month++;
            }
            if((month==2) && (nextDay==29) &&(year%4!=0))
            {
                month = 3;
                nextDay = 1;
            }
            if ((month == 2) && (nextDay == 30) && (year % 4 == 0))
            {
                month = 3;
                nextDay = 1;
            }
            if ((month == 1 || month == 3 || month == 5 || month == 7||month==8 ||month==10) && nextDay == 32)
            {
                nextDay = 1;
                month++;
            }
            if ((month == 12) && nextDay == 32)
            {
                month = 1;
                nextDay = 1;
                year++;
            }
            Console.WriteLine("{0}.{1}.{2}",nextDay ,month ,year );
        }
    }
}
