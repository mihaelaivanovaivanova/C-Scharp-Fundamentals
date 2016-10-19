using System;


namespace _11.BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            int result;
            int pValue = (n >> p) & 1;
            if (pValue == v)
            {
                result = n;
            }
            else
            {
                int mask = (1 << p);
                result = n ^ mask;
            }
            Console.WriteLine(result);

        }
    }
}
