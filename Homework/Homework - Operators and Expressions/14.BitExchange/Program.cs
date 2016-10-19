using System;


namespace _14.BitExchange
{
    class Program
    {
        static void Main()
        {
            long n = Int64.Parse(Console.ReadLine());
            long a3 = (n >> 3) & 1;
            long a4 = (n >> 4) & 1;
            long a5 = (n >> 5) & 1;
            long b24 = (n >> 24) & 1;
            long b25 = (n >> 25) & 1;
            long b26 = (n >> 26) & 1;
            long resultFirst = 0;
            long resultSecond = 0;
            long resultThird = 0;
            if (a3 == b24)
            {
                resultFirst  = n;
               // Console.WriteLine(Convert.ToString (resultFirst ,2).PadLeft (32,'0'));
            }
            else
            {
                long mask1 = 1 << 24;
                long afterMask1 = n  ^ mask1;
                long mask2 = 1 << 3;
                resultFirst = afterMask1  ^ mask2;
                // Console.WriteLine(Convert.ToString(resultFirst, 2).PadLeft(32, '0'));
            }
            if (a4 == b25)
            {
                resultSecond  = resultFirst ;
                // Console.WriteLine(Convert.ToString(resultSecond, 2).PadLeft(32, '0'));
            }
            else
            {
                long mask1 = 1 << 25;
                long afterMask1 = resultFirst ^ mask1;
                long mask2 = 1 << 4;
                resultSecond  = afterMask1 ^ mask2;
                // Console.WriteLine(Convert.ToString(resultFirst, 2).PadLeft(32, '0'));
            }
            if (a5 == b26)
            {
                resultThird = resultSecond;
                //Console.WriteLine(Convert.ToString(resultThird, 2).PadLeft(32, '0'));
            }
            else
            {
                long mask1 = 1 << 26;
                long afterMask1 = resultSecond ^ mask1;
                long mask2 = 1 << 5;
                resultThird = afterMask1 ^ mask2;
                //Console.WriteLine(Convert.ToString(resultThird, 2).PadLeft(32, '0'));
            }
            Console.WriteLine(resultThird );
        }
    }
}
