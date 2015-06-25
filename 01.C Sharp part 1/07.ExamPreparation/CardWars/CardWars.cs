using System;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        BigInteger firstPlayerScore = 0;
        BigInteger secondPlayerScore = 0;
        int firstPlayerGamesWon = 0;
        int secondPlayerGamesWon = 0;
        bool theXCardDrawnByFirstPlayer = false;
        bool theXCardDrawnBySecondPlayer = false;


        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int firstPlayerHandStrenght = 0;
            int secondPlayerHandStrenght = 0;

            
            for (int j = 0; j < 3; j++)
            {
                string firstPlayerCard = Console.ReadLine();

                switch (firstPlayerCard)
                {
                    case "A": firstPlayerHandStrenght += 1;
                        break;
                    case "J": firstPlayerHandStrenght += 11;
                        break;
                    case "Q": firstPlayerHandStrenght += 12;
                        break;
                    case "K": firstPlayerHandStrenght += 13;
                        break;
                    case "Z": firstPlayerScore *= 2;
                        break;
                    case "Y": firstPlayerScore -= 200;
                        break;
                    case "X": theXCardDrawnByFirstPlayer = true;
                        break;
                    default: firstPlayerHandStrenght += 12 - int.Parse(firstPlayerCard);
                        break;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                string secondPlayerCard = Console.ReadLine();

                switch (secondPlayerCard)
                {
                    case "A": secondPlayerHandStrenght += 1;
                        break;
                    case "J": secondPlayerHandStrenght += 11;
                        break;
                    case "Q": secondPlayerHandStrenght += 12;
                        break;
                    case "K": secondPlayerHandStrenght += 13;
                        break;
                    case "Z": secondPlayerScore *= 2;
                        break;
                    case "Y": secondPlayerScore -= 200;
                        break;
                    case "X": theXCardDrawnBySecondPlayer = true;
                        break;
                    default: secondPlayerHandStrenght += 12 - int.Parse(secondPlayerCard);
                        break;
                }
            }
            if (theXCardDrawnByFirstPlayer && theXCardDrawnBySecondPlayer)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
            }
            else if (theXCardDrawnByFirstPlayer)
            {
                break;
            }
            else if (theXCardDrawnBySecondPlayer)
            {
                break;
            }

            if (firstPlayerHandStrenght > secondPlayerHandStrenght)
            {
                firstPlayerScore += firstPlayerHandStrenght;
                firstPlayerGamesWon++;
            }
            else if (secondPlayerHandStrenght > firstPlayerHandStrenght)
            {
                secondPlayerScore += secondPlayerHandStrenght;
                secondPlayerGamesWon++;
            }
            firstPlayerHandStrenght = 0;
            secondPlayerHandStrenght = 0;
            theXCardDrawnByFirstPlayer = false;
            theXCardDrawnBySecondPlayer = false;
        }

        if (theXCardDrawnByFirstPlayer)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (theXCardDrawnBySecondPlayer)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
            Console.WriteLine("Games won: {0}", firstPlayerGamesWon);
        }
        else if (secondPlayerScore > firstPlayerScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerScore);
            Console.WriteLine("Games won: {0}", secondPlayerGamesWon);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
        }
    }
}
