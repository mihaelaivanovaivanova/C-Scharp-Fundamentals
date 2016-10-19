using System;


namespace Problem3_ForestRoad
{
    class Program
    {
        static void Main()
        {
            byte N = Byte.Parse(Console.ReadLine());
            int innerDots = 0;
            int outsideDots = N - 1;
            for(int i=0;i<N;i++)
            {
                Console.Write(new string ('.',innerDots ));
                Console.Write("*");
                Console.WriteLine(new string ('.', outsideDots));
                innerDots++;
                outsideDots--;
            }
            innerDots = N - 2;
            outsideDots = 1;
               for ( int i=0;i<N-1;i++)
            {
                Console.Write(new string('.', innerDots));
                Console.Write("*");
                Console.WriteLine(new string('.', outsideDots));
                innerDots--;
                outsideDots++;
            }
        }
    }
}
