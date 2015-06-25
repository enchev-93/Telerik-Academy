namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSMTest // problem 7
    {
        public static Random rnd = new Random();

        public static string[,] manufacturerAndModels =
        {
            {"Nokia", "Samsing", "Motorola", "Sony", "HTC"},
            {"Lumia", "Galaxy Note", "Nexus 6", "Xperia", "One"},
            {"3310", "Galaxy S5", "Moto", "Xperia T", "Desire"},
            {"Asha", "Galaxy Grand", "Droid", "Xperia J", "Butterfly"}
        };

        public static string[] owners = { "Pesho", "Gosho", "Ivo", "Doncho"};

        public static Battery[] batteries =
        {
            new Battery(), new Battery("Good", 250, 25, BatteryTypes.LiIon),
            new Battery("Bad", 50, 5, BatteryTypes.NiCd), new Battery("Test", 400, 40, BatteryTypes.NiMH)
        };

        public static Display[] display = { new Display(), new Display(4, 1000), new Display(5.7, 1000000) };

        public static GSM[] GenerateGSMs(int number)
        {
            GSM[] gsms = new GSM[number];

            for (int i = 0; i < number; i++)
            {
                int col = rnd.Next(0, manufacturerAndModels.GetLength(1));
                int row = rnd.Next(1, manufacturerAndModels.GetLength(0));

                gsms[i] = new GSM(manufacturerAndModels[0, col], manufacturerAndModels[row, col], rnd.Next(1, 2001),
                    owners[rnd.Next(0, owners.Length)], batteries[rnd.Next(0, batteries.Length)],
                    display[rnd.Next(0,display.Length)], new List<Call>());
            }

            return gsms;
        }

        public static void PrintGSMsInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("Sample GSM {0}: {1}", i + 1, gsms[i]);
                Console.WriteLine();
            }

            Console.WriteLine("IPhone info: {0}", GSM.IPhone4S);
        }
    }
}
