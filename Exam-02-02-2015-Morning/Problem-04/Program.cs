using System;


namespace Problem_04
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int ousideSpace = n - 2;
            int xDown = n - 2;
            Console.Write(new string(' ',n-1 ));
            Console.WriteLine(new string(':',n));
            for(int i=1;i<n-1;i++)
            {
                Console.Write(new string(' ',ousideSpace));
                Console.Write(":");
                Console.Write(new string ('/',n-2));

                Console.Write(":");
                if (i >= 2)
                {
                    Console.Write(new string('x', i - 1));
                }
                Console.WriteLine(":");
                ousideSpace--;
            }
            Console.Write(new string(':', n));
            Console.Write(new string('x', n-2));
            Console.WriteLine(":");
            for (int i=1; i<=n-2;i++)
            {
                Console.Write(":");
                Console.Write(new string(' ', n - 2));
                Console.Write(":");
                if (i<n-2)
                {
                    Console.Write(new string('x',n-2- i));
                }
                Console.WriteLine(":");
            }
            Console.WriteLine(new string(':',n));

        }
    }
}
