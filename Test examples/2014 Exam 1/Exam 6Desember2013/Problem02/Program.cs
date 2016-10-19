using System;


namespace Problem02
{
    class Program
    {
        static void Main()
        {
            int i =0;
            int sum = 0;
            int counter = 0;
            //string Input = Console.ReadLine();
            while (true)
            {
                int charCode = Console.Read();
                char ch = (char)charCode;
                if (char.IsDigit(ch))
                {
                    if (i % 2 == 1)
                    {
                        sum +=(ch-48);
                        counter++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                  else if(char.IsLetter(ch))
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("{0} {1}",counter , sum);
        }
    }
}
