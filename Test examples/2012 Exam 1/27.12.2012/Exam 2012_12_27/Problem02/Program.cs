using System;


namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int numbersPerLine = 3;
            long totalNumbers = numberOfLines * (numberOfLines + 1) / 2;
            int m = 0;
            Console.WriteLine(firstNumber );
            Console.WriteLine("{0} {1}",secondNumber ,thirdNumber );
            long[] allNumbers = new long[totalNumbers - 3];
            for (int i=0;i<totalNumbers -3;i++)
            {
                allNumbers[i] = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = allNumbers [i];
            }
            for(int i=2; i <= numberOfLines-1; i++)
            {
               
                for (int j=0; j<numbersPerLine;j++)
                {
                    if(j<numbersPerLine -1)
                        {
                        Console.Write("{0} ", allNumbers[m]);
                        if (m < totalNumbers - 4)
                        {
                            m++;
                        }
                    }
                    else
                    {
                        Console.WriteLine(allNumbers [m]);
                        if (m < totalNumbers - 4)
                        {
                            m++;
                        }
                    }
                }
                numbersPerLine++;
            }

        }
    }
}
