using System;

class BatGoikoTower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int width = h * 2;

        int towerWidth = 2;
        int nextCrossbeamRow = 2;
        int currentStep = 2;
        for (int row = 1; row <= h; row++)
        {
            string sidePoints = new string('.', (width - towerWidth) / 2);
            string middleSymbols;

            if (row == nextCrossbeamRow || row == nextCrossbeamRow + 2 || row == nextCrossbeamRow + 5 || row == nextCrossbeamRow + 9 || row == nextCrossbeamRow + 14 || row == nextCrossbeamRow + 20 || row == nextCrossbeamRow + 27 || row == nextCrossbeamRow + 35)
            {
                middleSymbols = new string('-', width - (sidePoints.Length * 2) - 2);
                currentStep++;
            }
            else
            {
                middleSymbols = new string('.', width - (sidePoints.Length * 2) - 2);
            }

            Console.WriteLine(sidePoints + "/" + middleSymbols + "\\" + sidePoints);

            towerWidth += 2;
        }
    }
}
