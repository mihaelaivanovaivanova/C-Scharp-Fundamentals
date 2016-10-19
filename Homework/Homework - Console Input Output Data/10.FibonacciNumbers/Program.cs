using System;


namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Insert an integer number");
            int n = Int32.Parse(Console.ReadLine());
            {
                if (n == 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    long firstNum = 0;
                    long secondNum = 1;
                    Console.Write("{0}, {1}, ", firstNum, secondNum);
                    for (int i = 2; i < n; i++)
                    {
                        long thirdNum = firstNum + secondNum;
                        if (i < n - 1)
                        {
                            Console.Write("{0}, ", thirdNum);
                        }
                        else
                        {
                            Console.Write("{0}", thirdNum);
                        }
                        firstNum = secondNum;
                        secondNum = thirdNum;
                    }
                }
            }
        }
    }
}
