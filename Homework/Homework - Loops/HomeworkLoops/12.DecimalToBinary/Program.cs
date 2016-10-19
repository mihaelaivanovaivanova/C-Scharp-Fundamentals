using System;


namespace _12.DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());
           int length = decimalNumber.ToString().Length;
            string bitNumber=null;
            string tempString;
            int tempDecimal = decimalNumber;
            int Reminder;
            while(tempDecimal>0)
            {
                Reminder = tempDecimal % 2;
                tempString = Reminder.ToString();
                bitNumber = tempString+bitNumber;
                tempDecimal /= 2;
            }
            Console.WriteLine(bitNumber );
        }
    }
}
