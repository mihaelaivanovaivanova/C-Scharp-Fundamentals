using System;


namespace _14.BitExchange
{
    class Program
    {
        static void Main()
        {
            long n = Int64.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long byteP = 0;
            long byteQ = 0;
            long result = n;
            long finalResult;
            int i;
            int j;
            for (i = p, j = q; i <= (p + k - 1); i++, j++)
            //for (int j = q; j <= q + k - 1; j++)
            {
                byteP = (n >> i) & 1;
                byteQ = (n >> j) & 1;
                if (byteP == byteQ)
                {
                    finalResult = result;
                }
                else
                {
                    long mask1 = 1 << i;
                    long afterMask1 = result ^ mask1;
                    long mask2 = 1 << j;
                    result = afterMask1 ^ mask2;
                    finalResult = result;
                }
            }
            long total = finalResult;
            Console.WriteLine(finalResult);
        }

    }
}
    

