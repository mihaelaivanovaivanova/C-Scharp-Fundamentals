using System;


namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int br = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = br; j <= (n - 1 + br); j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
                br++;
            }

        }
    }
}
