using System;


namespace _08.DigitAsWord
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert a digit:");
            string inputValue = Console.ReadLine();
            int number;
            if (int.TryParse(inputValue, out number))
            {
                switch (number)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    default: Console.WriteLine("not a digit"); break;

                }
            }
            else
                Console.WriteLine("not a digit");
        }
    }
}
