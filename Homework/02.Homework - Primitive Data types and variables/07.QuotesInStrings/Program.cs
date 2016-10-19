using System;


namespace _07.QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string one = @"The ""use"" of quotations causes difficulties";
            string two = "The \"use\" of quatations causes difficulties";
            Console.WriteLine(one);
            Console.WriteLine(two );
        }
    }
}
