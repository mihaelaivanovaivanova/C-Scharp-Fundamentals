using System;


namespace _04.PrintADeck
{
    class Program
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int cardNumber;
            if (int.TryParse(card, out cardNumber))
            {
                if (cardNumber >= 2 && cardNumber <= 10)
                {
                    for (int i = 2; i <= cardNumber; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",i);
                    }
                }
            }
            if ((card == "J") || (card=="Q") || (card=="K") || (card=="A"))
            {
                for (int i = 2; i <= 10; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",i);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                if ((card == "Q") || (card == "K") || (card == "A"))
                {
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                }
                if ((card == "K") || (card == "A"))
                {
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                }
                if (card == "A")
                {
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                }
            }
            //else
            //{
            //    for (int i = 50; i <= 57; i++)
            //    {
            //        console.writeline("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", (char)i);
            //        console.writeline("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 10);
            //    }

            //}

        }
    }
}
