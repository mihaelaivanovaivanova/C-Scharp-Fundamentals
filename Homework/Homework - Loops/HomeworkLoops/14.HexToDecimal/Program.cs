using System;
using System.Numerics;

namespace _14.HexToDecimal
{
    class Program
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine().ToUpper();
            int length = hexNumber.ToString().Length;
            BigInteger decNumber = 0;
            for (int i =0; i<=(length-1); i++)
            {
                //int presentNumber = hexNumber[length - i - 1];
                //string presentLetter = presentNumber.ToString();
               if ((int)(hexNumber[length - i - 1])<=57)
                {
                    decNumber += (hexNumber[length - i - 1]-48) * (long) Math.Pow(16, i);
                }
                else
                {
                    switch ( hexNumber[length - i - 1])
                    {
                        case 'A':
                            decNumber += 10 * (long)Math.Pow(16, i);
                            break;
                        case 'B':
                            decNumber += 11 * (long)Math.Pow(16, i);
                            break;
                        case 'C':
                            decNumber += 12 * (long)Math.Pow(16, i);
                            break;
                        case 'D':
                            decNumber += 13 * (long)Math.Pow(16, i);
                            break;
                        case 'E':
                            decNumber += 14 * (long)Math.Pow(16, i);
                            break;
                        case 'F':
                            decNumber += 15 * (long)Math.Pow(16, i);
                            break;
                    }
                }
            }
            Console.WriteLine(decNumber);
        }
    }
}
