using System;


namespace _08.IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            var b = '\u00A9';
            string lineOne = "   " + b + "   ";
            string lineTwo = "  " + b +" "+ b + "  ";
            string lineThree = " " + b + "   " + b+ " ";
            string lineFour = b + " " + b + " " + b + " "+b;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",lineOne , lineTwo ,lineThree ,lineFour );
         }
    }
}
