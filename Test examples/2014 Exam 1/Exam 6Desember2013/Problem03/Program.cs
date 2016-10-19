using System;

namespace Problem03
{
    class Program
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            long result = 0;
            long bracketResult = 0;
            bool inBracket = false; 
            char currentOperator = '+';
            char bracketOperator = '+';
            foreach (char symbol in expression )
            {
                if (symbol =='(')
                {
                    inBracket = true;
                    continue;
                }
                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {

                            case '+': result += bracketResult; break;
                            case '-': result -= bracketResult; break;
                            case '%': result %= bracketResult; break;
                            case '*': result *= bracketResult; break;
                        
                    }
                    bracketOperator = '+';
                    bracketResult = 0;
                    
                }
                if (inBracket == false)
                {
                    if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/' || symbol == '%')
                    {
                        currentOperator = symbol;
                    }
                }
                else
                {
                    if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/' || symbol == '%')
                    {
                        bracketOperator  = symbol;
                    }
                }
                if (inBracket == true)
                {
                    if (char.IsDigit(symbol))
                    {
                        long bracketNumber = symbol - 48;
                        switch (bracketOperator )
                        {
                            case '+': bracketResult += bracketNumber; break;
                            case '-': bracketResult -= bracketNumber; break;
                            case '%': bracketResult %= bracketNumber; break;
                            case '*': bracketResult *= bracketNumber; break;

                        }
                    }
                }
                else
                {
                    if (char.IsDigit(symbol))
                    {
                        long currentNumber = symbol - 48;
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '%': result %= currentNumber; break;
                            case '*': result *= currentNumber; break;

                        }
                    }
                }
            }

            Console.WriteLine("{0:F3}", result );
        }
    }
}
