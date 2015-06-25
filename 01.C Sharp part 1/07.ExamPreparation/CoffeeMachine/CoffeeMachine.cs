using System;
using System.Threading;
using System.Globalization;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int tray1 = int.Parse(Console.ReadLine());
        int tray2 = int.Parse(Console.ReadLine());
        int tray3 = int.Parse(Console.ReadLine());
        int tray4 = int.Parse(Console.ReadLine());
        int tray5 = int.Parse(Console.ReadLine());
        decimal givenAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        if (givenAmount < drinkPrice)
        {
            decimal diffrence = drinkPrice - givenAmount;
            Console.WriteLine("More {0:F2}", diffrence);
        }
        else
        {
            decimal moneyInTrays =
                0.05m * tray1 +
                0.10m * tray2 +
                0.20m * tray3 +
                0.50m * tray4 +
                1.00m * tray5;
            decimal changeToGive = givenAmount - drinkPrice;
            decimal diffrence = Math.Abs(moneyInTrays - changeToGive);

            if (changeToGive <= moneyInTrays)
            {
                Console.WriteLine("Yes {0:F2}", diffrence);
            }
            else
            {
                Console.WriteLine("No {0:F2}", diffrence);
            }
        }
    }
}
