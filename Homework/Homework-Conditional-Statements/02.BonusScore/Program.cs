using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert an integer number between 1 and 9");
            int number = int.Parse(Console.ReadLine());
            if(number>=1 & number <=3)
            {
                number = number * 10;
                Console.WriteLine(number);
            }
            else if (number >= 4 & number <= 6)
            {
                number = number * 100;
                Console.WriteLine(number);
            }
            else if (number>=7 & number <=9)
            {
                number = number * 1000;
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
