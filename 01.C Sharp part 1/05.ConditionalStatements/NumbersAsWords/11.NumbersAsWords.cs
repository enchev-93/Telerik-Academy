//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:

//numbers	number as words
//0	        Zero
//9	        Nine
//10	    Ten
//12	    Twelve
//19	    Nineteen
//25	    Twenty five
//98	    Ninety eight
//98	    Ninety eight
//273	    Two hundred and seventy three
//400	    Four hundred
//501	    Five hundred and one
//617	    Six hundred and seventeen
//711	    Seven hundred and eleven
//999	    Nine hundred and ninety nine

using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Sorry, but you have to enter a number between 0 and 999!");

        }
        int hundred = number / 100;
        int ten = (number / 10) % 10;
        int digit = number % 10;
        int teen = 10 + digit;

        string teenText = "";
        string tenText = "";
        string digitText = "";
        string hundredText = "";

        switch (teen)
        {
            case 11: teenText = " eleven";
                break;
            case 12: teenText = " twelve";
                break;
            case 13: teenText = " thirteen";
                break;
            case 14: teenText = " fourteen";
                break;
            case 15: teenText = " fifteen";
                break;
            case 16: teenText = " sixteen";
                break;
            case 17: teenText = " seventeen";
                break;
            case 18: teenText = " eighteen";
                break;
            case 19: teenText = " nineteen";
                break;
        }
        switch (hundred)
        {
            case 1: hundredText = "one hundred";
                break;
            case 2: hundredText = "two hundred";
                break;
            case 3: hundredText = "three hundred";
                break;
            case 4: hundredText = "four hundred";
                break;
            case 5: hundredText = "five hundred";
                break;
            case 6: hundredText = "six hundred";
                break;
            case 7: hundredText = "seven hundred";
                break;
            case 8: hundredText = "eight hundred";
                break;
            case 9: hundredText = "nine hundred";
                break;
            case 0: hundredText = "";
                break;
        }
        if (number % 100 != 0 && number >= 100)
        {
            hundredText = hundredText + " and";
        }
        if (ten == 1 && digit > 0)
        {
            Console.WriteLine(hundredText + teenText);
            hundredText = tenText = "";
        }
        switch (ten)
        {
            case 1: tenText = " ten ";
                break;
            case 2: tenText = " twenty";
                break;
            case 3: tenText = " thirty";
                break;
            case 4: tenText = " fourty";
                break;
            case 5: tenText = " fifty";
                break;
            case 6: tenText = " sixty";
                break;
            case 7: tenText = " seventy";
                break;
            case 8: tenText = " eighty";
                break;
            case 9: tenText = " ninety";
                break;
            case 0: tenText = "";
                break;
        }
        switch (digit)
        {
            case 1: digitText = " one ";
                break;
            case 2: digitText = " two ";
                break;
            case 3: digitText = " three ";
                break;
            case 4: digitText = " four ";
                break;
            case 5: digitText = " five ";
                break;
            case 6: digitText = " six ";
                break;
            case 7: digitText = " seven ";
                break;
            case 8: digitText = " eight ";
                break;
            case 9: digitText = " nine ";
                break;
            default: digitText = "";
                break;
        }
        if (number == 0)
        {
            Console.WriteLine("Zero");
            hundredText = tenText = digitText = "";
        }
        if (number <= 10 || number >= 20)
        {
            Console.WriteLine(hundredText + tenText + digitText);
        }

    }
}
