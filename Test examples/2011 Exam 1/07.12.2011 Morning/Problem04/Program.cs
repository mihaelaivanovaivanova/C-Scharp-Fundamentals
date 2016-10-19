using System;


namespace Problem04
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] arrayForDecimal = new int[n] ;
            int counter = 0;
            int innerCount = 1;
            for (int i=0;i< n;i++)
            {
                arrayForDecimal[i] = int.Parse (Console.ReadLine());
            }
            string[] arrayForBin = new string[n];
            for (int i=0;i< n;i++)
            {
                arrayForBin[i] = Convert.ToString(arrayForDecimal[i], 2);
            }
            for (int i=0;i< n;i++)
            {
                int binNumber = int.Parse(arrayForBin[i]);
                while (binNumber >= 10)
                {
                    for (int j = 0; j < k + 1; j++)
                    {
                        int temp = binNumber % 10;
                        binNumber /= 10;
                        int toCompare = binNumber % 10;
                        if(temp==toCompare )
                        {
                            innerCount += 1;
                        }
                    }
                }
            }
        }
    }
}
