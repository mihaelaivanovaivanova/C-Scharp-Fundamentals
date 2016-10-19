using System;


namespace Problem04
{
    class Program
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            // ears
            Console.Write(' ' + c + new string(' ', 1 + ((s - 10) / 4)) + c + new string(' ', 9 + (s - 10) / 2));
            Console.WriteLine();
            //head
            for (int i=0; i<=(s-10)/4;i++)
            {
                Console.Write(' ' + new string(Convert.ToChar(c), 3 + ((s - 10) / 4)) + new string(' ', s/2));
                Console.WriteLine();
            }
            //neck
            for (int i = 0; i<=(s-10)/4 ; i++)
            {
                Console.Write("  " + new string(Convert.ToChar(c), 1 + ((s - 10) / 4)) + new string(' ', s / 2+1));
                Console.WriteLine();
            }
            //body part 1/5
            for (int i = 0; i <= (s - 10) / 4; i++)
            {
                Console.Write(' ' + new string(Convert.ToChar(c), 3 + ((s - 10) / 4)) + new string(' ', s/2));
                Console.WriteLine();
            }
            //body part 2/5 + tail
            Console.Write(' ' + new string(Convert.ToChar(c), 3 + ((s - 10) / 4)) + new string(' ', 3)+ new string(Convert .ToChar (c), 2 + ((s - 10) / 4)));
            Console.WriteLine();
            //body part 3/5
            for (int i = 0; i < (3 + (s - 10) / 4); i++)
            {
                Console.Write(new string(Convert.ToChar(c), 5 + (s - 10) / 4) +"  " +c+new string (' ',1+(s-10)/2));
                Console.WriteLine();
            }
            //body part 4/5
            Console.Write(new string(Convert.ToChar(c), 5 + (s - 10) / 4) + " " + c +c+ new string(' ', 1 + (s - 10) / 2));
            Console.WriteLine();
            //body part 5/5
            Console.Write(' ' + new string(Convert.ToChar(c), 6+(s-10)/4) + new string(' ', 2 + (s - 10) / 2));
            Console.WriteLine();

        }
    }
}
