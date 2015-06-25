using System;

class Garden
{
    static void Main()
    {
        double tomatoAmount = double.Parse(Console.ReadLine());
        double tomatoArea = double.Parse(Console.ReadLine());
        double cucumberAmount = double.Parse(Console.ReadLine());
        double cucumberArea = double.Parse(Console.ReadLine());
        double potatoAmount = double.Parse(Console.ReadLine());
        double potatoArea = double.Parse(Console.ReadLine());
        double carrotAmount = double.Parse(Console.ReadLine());
        double carrotArea = double.Parse(Console.ReadLine());
        double cabbageAmount = double.Parse(Console.ReadLine());
        double cabbageArea = double.Parse(Console.ReadLine());
        double beansAmount = double.Parse(Console.ReadLine());

        double tomatoCost = 0.5;
        double cucumberCost = 0.4;
        double potatoCost = 0.25;
        double carrotCost = 0.6;
        double cabbageCost = 0.3;
        double beansCost = 0.4;
        double areaAll = 250;
        double sum = 0;

        double sumTomato = tomatoAmount * tomatoCost;
        double sumCucumber = cucumberAmount * cucumberCost;
        double sumPotato = potatoAmount * potatoCost;
        double sumCarrot = carrotAmount * carrotCost;
        double sumCabbage = cabbageAmount * cabbageCost;
        double sumBeans = beansAmount * beansCost;

        sum = sumTomato + sumCucumber + sumPotato + sumCarrot + sumCabbage + sumBeans;
        Console.WriteLine("Total costs: {0:F2}", sum);

        double beansArea = 0;
        double areaUsed = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        beansArea = areaAll - areaUsed;
        
        if (areaUsed > areaAll)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (areaUsed == areaAll)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
    }
}