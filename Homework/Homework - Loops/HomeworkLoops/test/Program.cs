using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char card = Char.Parse(Console.ReadLine());
            int cardNumber = Convert.ToInt32(card);
            for (int i = 50; i <= cardNumber; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }

        }
    }
}
