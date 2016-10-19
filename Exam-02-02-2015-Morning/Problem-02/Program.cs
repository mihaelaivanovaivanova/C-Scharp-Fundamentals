using System;

namespace Problem_02
{
    class Program
    {
        static void Main()
        {
            
            double m = double.Parse(Console.ReadLine());
            string ourInput = Console.ReadLine();
            char [] convertedString = ourInput .ToCharArray();
            double result = 0;
            for(int i=0; i<=ourInput .Length;i++)
            {
                if (convertedString [i]!='@')
                { int CurrentNumberFromAscii = (int)(convertedString[i]);
                    if ((CurrentNumberFromAscii >= 48) && (CurrentNumberFromAscii <= 57))
                    {
                        result *= (CurrentNumberFromAscii - 48);
                    }
                    else if ((CurrentNumberFromAscii >= 65) && (CurrentNumberFromAscii <= 90))
                    {
                        result += (CurrentNumberFromAscii - 65);
                    }
                    else if ((CurrentNumberFromAscii >= 97) && (CurrentNumberFromAscii <= 122))
                    {
                        result += (CurrentNumberFromAscii - 97);
                    }
                    else
                    {
                        result %= m;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
