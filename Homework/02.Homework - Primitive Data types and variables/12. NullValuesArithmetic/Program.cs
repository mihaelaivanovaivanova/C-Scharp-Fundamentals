using System;


namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? firstNum = null;
            double? secondNum = null;
            Console.WriteLine(firstNum );
            Console.WriteLine(secondNum );
            firstNum =  5;
            secondNum  = -2.18;
            Console.WriteLine(firstNum );
            Console.WriteLine(secondNum );
        }
    }
}
