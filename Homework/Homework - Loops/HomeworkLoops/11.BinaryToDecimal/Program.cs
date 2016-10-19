using System;


namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();
            int length = binNumber.ToString().Length;
            long decNumber=0;
            for (int i=0; i<=(length -1); i++)
            {
                if (binNumber[ binNumber.Length -i -1] == '0')
                {
                    continue;
                }
                decNumber +=(long) Math.Pow(2, i);
            }
            Console.WriteLine(decNumber );
        }
    }
}
