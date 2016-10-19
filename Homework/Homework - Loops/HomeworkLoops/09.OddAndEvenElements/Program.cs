using System;


namespace _09.OddAndEvenElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string integers = Console.ReadLine();
            long productOdd = 1;
            long productEven = 1;
            var integersList = integers.Split(' ');
            for (int i =0; i<= n-1;i+=2)
            {
                int oddNumber = int.Parse(integersList[i]);
                productOdd *= oddNumber;
            }
            for (int j = 1; j <= n-1; j += 2)
            {
                int evenNumber = int.Parse(integersList[j]);
                productEven *= evenNumber;
            }
                if (productEven == productOdd )
            {
                Console.WriteLine("yes {0}", productOdd );
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd ,productEven );
            }
        }
    }
}
