using System;
using System.Numerics;

namespace Problem02
{
    class Program
    {
        static void Main()
        {   
            long specialNumber = 0;
            while (true)
            {
                int number = Console.Read();
                char digit = (char)number;
                if(char.IsDigit (digit))
                {
                    specialNumber += digit - 48;
                }
                if(digit=='.'||digit=='-'||digit==',')
                {
                    continue;
                }
                if(char.IsDigit (digit)==false &&digit!='.'&&digit!='-'&&digit!=',')
                {
                    break;
                }
            }
            if (specialNumber > 9)
            {
                long newResult = 0;
                while (specialNumber > 9)
                {
                    
                    newResult += specialNumber % 10;
                    specialNumber /= 10;
                    if (specialNumber <10)
                    {
                        newResult += specialNumber;
                        if (newResult > 9)
                        {
                            long temp = newResult % 10;
                            newResult /= 10;
                            temp += newResult;
                            Console.WriteLine(temp);
                        }
                        else
                        {
                            Console.WriteLine(newResult);
                        }
                    }
                }
  
            }
            else
            {
                Console.WriteLine(specialNumber );
            }
                    }
    }
}
