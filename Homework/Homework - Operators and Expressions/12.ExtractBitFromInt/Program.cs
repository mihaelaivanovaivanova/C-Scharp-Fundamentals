using System;


namespace _11.BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {

            long n = Int64.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            long bit = (n >> p) & 1;
            Console.WriteLine(bit);
        }
    }
}
