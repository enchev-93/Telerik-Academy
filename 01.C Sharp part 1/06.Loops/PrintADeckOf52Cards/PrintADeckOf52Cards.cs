//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a 
//standard deck of 52 cards (without the jokers). The cards should be 
//printed using the classical notation (like 5 of spades, A of hearts, 
//9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds,
//hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds

using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        char clubs = (char)9827;
        char diams = (char)9830;
        char hearts = (char)9829;
        char spades = (char)9824;

        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine(i.ToString() + " " + (clubs) + " " + i.ToString() + " " + diams + " " + i.ToString() + " " + hearts + " " + i.ToString() + " " + spades);
            }
            else
            {
                switch (i)
                {
                    case 11: 
                        Console.WriteLine("J " + clubs + " " + "J " + diams + " " + "J " + hearts + " " + "J " + spades); 
                        break;
                    case 12:
                        Console.WriteLine("D " + clubs + " " + "D " + diams + " " + "D " + hearts + " " + "D " + spades); 
                        break;
                    case 13: 
                        Console.WriteLine("K " + clubs + " " + "K " + diams + " " + "K " + hearts + " " + "K " + spades); 
                        break;
                    case 14: 
                        Console.WriteLine("A " + clubs + " " + "A " + diams + " " + "A " + hearts + " " + "A " + spades); 
                        break;
                }
            }
        }

    }
}
