using System;

class Problem2
{
    static void Main()
    {
        double secret = double.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        double charDigit = 0;
        double charLetter = 0;
        double charElse = 0;

        double even = 0;

        foreach (char symbol in text)
        {

            if (symbol == '@')
            {
                break;
            }

            else if (symbol >= 'A' && symbol <= 'Z')
            {
                charLetter += symbol * secret + 1000;
                even++;
                if (even % 2 != 0)
                {
                    charLetter /= 100;
                    Console.WriteLine("{0:F2}", charLetter);
                }
                else if (even % 2 == 0)
                {
                    charLetter *= 100;
                    Console.WriteLine("{0}", charLetter);
                }
                charLetter = 0;
            }
            else if (symbol >= 'a' && symbol <= 'z')
	        {
                charLetter += symbol * secret + 1000;
                even++;
                if (even % 2 != 0)
                {
                    charLetter /= 100;
                    Console.WriteLine("{0:F2}", charLetter);
                }
                else if (even % 2 == 0)
                {
                    charLetter *= 100;
                    Console.WriteLine("{0}", charLetter);
                }
                 charLetter = 0;
	        }

            else if (symbol >= '0' && symbol <= '9')
            {
                charDigit += symbol + secret + 500;
                even++;
                if (even % 2 != 0)
                {
                    charDigit /= 100;
                    Console.WriteLine("{0:F2}", charDigit);
                }
                else if (even % 2 == 0)
                {
                    charDigit *= 100;
                    Console.WriteLine("{0}", charDigit);
                }
                charDigit = 0;
            }
            else
            {
                charElse += symbol - secret;
                even++;
                if (even % 2 != 0)
                {
                    charElse /= 100;
                    Console.WriteLine("{0:F2}", charElse);
                }
                else if (even % 2 == 0)
                {
                    charElse *= 100;
                    Console.WriteLine("{0}", charElse);
                }
                charElse = 0;
            }
        }
    }
}
