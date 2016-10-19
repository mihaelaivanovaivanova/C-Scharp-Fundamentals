using System;


namespace _11.BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string lastName = Console.ReadLine();
            double balance = Double.Parse(Console.ReadLine());
            string bankName = Console.ReadLine();
            long iban = long.Parse(Console.ReadLine());
            long CardNum1 = long.Parse(Console.ReadLine());
            long CardNum2 = long.Parse(Console.ReadLine());
            long CardNum3 = long.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}",firstName );
            Console.WriteLine("Middle name: {0}", secondName );
            Console.WriteLine("Last name: {0}",lastName );
            Console.WriteLine("Balance: {0}",balance);
            Console.WriteLine("Bank name: {0}", bankName );
            Console.WriteLine("Card number 1: {0}", CardNum1);
            Console.WriteLine("Card number 2: {0}", CardNum2);
            Console.WriteLine("Card number 3: {0}", CardNum3);


        }
    }
}
