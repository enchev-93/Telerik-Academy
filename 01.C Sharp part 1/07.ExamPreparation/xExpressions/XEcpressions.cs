using System;

class XEcpressions
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();

        decimal result = 0;
        decimal currentBrackerResul = 0;
        bool inBracket = false;

        char currentOperator = '+';
        char currentBracketOperator = '+';

        foreach (char symbol in expression)
        {

            if (symbol == '(')
            {
                inBracket = true;
                continue;
            }

            if (symbol == ')')
            {
                inBracket = false;
                switch (currentOperator)
                {
                    case '+': result += currentBrackerResul; break;
                    case '-': result -= currentBrackerResul; break;
                    case '*': result *= currentBrackerResul; break;
                    case '/': result /= currentBrackerResul; break;
                }
                currentBrackerResul = 0;
                currentBracketOperator = '+';
            }

            if (symbol == '+' ||
                symbol == '-' ||
                symbol == '*' ||
                symbol == '/')
            {
                if (inBracket)
                {
                    currentBracketOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }

            if (symbol >= '0' && symbol <= '9')
            {
                int currentNumber = symbol - '0';

                if (inBracket)
                {
                    switch (currentBracketOperator)
                    {
                        case '+': currentBrackerResul += currentNumber; break;
                        case '-': currentBrackerResul -= currentNumber; break;
                        case '*': currentBrackerResul *= currentNumber; break;
                        case '/': currentBrackerResul /= currentNumber; break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber; break;
                        case '-': result -= currentNumber; break;
                        case '*': result *= currentNumber; break;
                        case '/': result /= currentNumber; break;
                    }
                }
            }
        }
        Console.WriteLine("{0:F2}", result);
    }
}
