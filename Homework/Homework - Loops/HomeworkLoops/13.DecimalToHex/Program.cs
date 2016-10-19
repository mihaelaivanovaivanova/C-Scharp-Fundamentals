using System;


namespace _13.DecimalToHex
{
    class Program
    {
        static void Main()
        {
            long decimaNumber = long.Parse(Console.ReadLine());
            string hexString = null;
            long tempDecimal = decimaNumber;
            string tempString = null;
            long reminder;
            while(tempDecimal  >0)
            {
                reminder = tempDecimal % 16;
                switch (reminder)
                {
                    case 0:
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        tempString = reminder.ToString();
                        hexString = tempString + hexString;
                        break;
                    case 10:
                        hexString ="A"+ hexString;
                        break;
                    case 11:
                        hexString = "B" + hexString;
                        break;
                    case 12:
                        hexString ="C"+ hexString;
                        break;
                    case 13:
                        hexString = "D" + hexString;
                        break;
                    case 14:
                        hexString ="E"+ hexString;
                        break;
                    case 15:
                        hexString = "F" + hexString;
                        break;
                }
                tempDecimal /= 16;
            }
            Console.WriteLine(hexString);   
        }
    }
}
