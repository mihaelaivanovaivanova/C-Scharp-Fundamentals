using System;


namespace Problem05
{
    class Program
    {
        static void Main()
        {
            int [] input = new int [16];
            for (int i=0;i<16;i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine(),2);

            }
            while (true)
            {
                string question = Console.ReadLine();
                if (question=="what is")
                {
                    int number = int.Parse(Console.ReadLine());
                    int possition =int.Parse(Console.ReadLine());
                    if (number >= 1 && number<=14 && possition >= 1 && possition <= 14)
                    {
                        int maskForNumber = ((input[number] >> (15 - possition - 1))) & 15;
                        int maskForNumberPlusOne = (input[number + 1] >> (15 - possition - 1)) & 15;
                        int maskForNumberMinussOne = (input[number - 1] >> (15 - possition - 1)) & 15;
                        if ((maskForNumber== 15) && (maskForNumberPlusOne == 15) && (maskForNumberMinussOne == 15))
                        {
                            Console.WriteLine("cookie");
                        }
                        else if ((maskForNumber == 2 && maskForNumberMinussOne == 0 && maskForNumberPlusOne == 0))
                        {
                            Console.WriteLine("cookie crumb");
                        }
                        else
                        {
                            Console.WriteLine("broken cookie");
                        }
                    }
                    if(number ==0 || number ==15)
                    {
                        int maskForNumber = ((input[number] >> (15 - possition - 1))) & 15;
                        if (maskForNumber ==2)
                    }
                    if (question=="pay")
                    {
                        break;
                    }
                }
            }
        }
    }
}
