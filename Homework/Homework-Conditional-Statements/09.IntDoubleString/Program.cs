using System;


namespace _09.IntDoubleString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1-->int\n2-->double\n3-->string");
            int choice = int.Parse(Console.ReadLine());
            if (choice==1)
            {
                Console.WriteLine("Please insert an integer number:");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum+1);
            }
            if (choice==2)
            {
                Console.WriteLine("Please insert a double type number:");
                double doubleNum = Double.Parse(Console.ReadLine());
                Console.WriteLine( doubleNum + 1);
            }
            if (choice ==3)
            {
                Console.WriteLine("Please insert a string");
                string inputString = Console.ReadLine();
                Console.WriteLine("{0}*",inputString );
            }
        }

    }
}
