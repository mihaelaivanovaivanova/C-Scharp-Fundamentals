using System;


namespace _11.BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int bit = (n >> 3) & 1;
            Console.WriteLine(bit);
        }  
    }
}
