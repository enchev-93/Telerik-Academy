//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:

//weight	weight on the Moon
//86	      14.62
//74.6	      12.682
//53.7	      9.129

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double gravityOnMoon = 0.17;
        Console.WriteLine("Enter weight ");
        double weightOfAMan = double.Parse(Console.ReadLine());
        double weightOfAManOnTheMoon = gravityOnMoon * weightOfAMan;

        Console.Clear();
        Console.WriteLine("The weight on the Earth for this guys is: {0} \nThe weight on the Moon for thi guys is: {1}",
            weightOfAMan, weightOfAManOnTheMoon);
    }
}
