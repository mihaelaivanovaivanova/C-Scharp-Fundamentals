using System;


namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string hellW = Convert.ToString(helloWorld);
            Console.WriteLine(hellW);
        }
    }
}
