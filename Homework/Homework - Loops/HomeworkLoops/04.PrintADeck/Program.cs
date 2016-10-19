using System;


namespace _04.PrintADeck
{
    class Program
    {
        static void Main()
        {
            char card = Char.Parse(Console.ReadLine());
            int cardNumber = Convert.ToInt32(card);
            if (cardNumber >= 50 && cardNumber <= 57)
            {
                for (int i = 50; i <= cardNumber; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",(char) i);
                }
            }
            if ((cardNumber == 65) || (cardNumber == 74) || (cardNumber == 75) || (cardNumber == 81))
            {
                for (int i = 50; i <= 57; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", (char)i);
                }
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 10);
                bool CardJ = (card == 'J');
                bool CardQ = (card == 'Q');
                bool CardK = (card == 'K');
                bool CardA = (card == 'A');

                if (CardJ || CardQ || CardK || CardA)
                {
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                }
                if (CardQ || CardK || CardA)
                {
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                }
                if (CardK || CardA)
                {
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                }
                if (CardA)
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
