using System;


namespace Problem04
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //1st half
            for (int i = (((n - 2) / 2) - 1); i >= 0; i--)
            {
                Console.Write(new string('.', i + 1));
                int j = i + 1;
                while (j <= n / 2 - 1)
                {
                    Console.Write("/");
                    j += 1;
                    if (j < n / 2)
                    {
                        Console.Write(" ");
                        j += 1;
                    }
                }
                //2nd fourth
                int k = i+2;
                while (k < n - i - 2)
                {
                    Console.Write("\\");
                    k = i + 3;
                    if (k < n - i - 3)
                    {
                        Console.Write(" ");
                        k += 1;
                    }
                    k += 2;
                }
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
            
        }
    }
}
