using System;


namespace Problem04
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));
            for (int i =1; i<n; i++)
            {
                Console.Write(new string('.', n-i));
                Console.Write("*");
                if (i - 1 > 0)
                {
                    Console.Write(new string('.', i - 1));
                }
                Console.Write("*");
                if (i - 1 > 0)
                {
                    Console.Write(new string('.', i - 1));
                }
                Console.Write("*");
                Console.WriteLine(new string('.', n - i));
            }
            Console.WriteLine(new string('*', 2 * n +1));
            for (int i=1;i<= 5+((n-3)/2)*3-n-1;i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                if(n-i-1>0)
                {
                    Console.Write(new string('.',(n- i )- 1));
                }
                Console.Write("*");
                if (n-i - 1 > 0)
                {
                    Console.Write(new string('.', (n-i) - 1));
                }
                Console.Write("*");
                Console.WriteLine(new string('.', i));
            }
            Console.Write(new string('.', (n + 1) / 2));
            Console.Write(new string('*', n));
            Console.Write(new string('.', (n + 1) / 2));
        }
    }
}
