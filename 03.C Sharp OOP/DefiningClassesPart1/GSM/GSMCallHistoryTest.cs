namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest // problem 12
    {
        public static GSM testGSM = new GSM("TestGSM", "TestModel");

        public static DateTime testCall1Date = DateTime.Parse("07/03/2015 09:25:10");
        public static DateTime testCall2Date = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime testCall3Date = DateTime.Parse("09/03/2015 14:07:18");
        public static DateTime testCall4Date = DateTime.Parse("10/03/2015 08:15:55");
        public static DateTime testCall5Date = DateTime.Parse("10/03/2015 12:37:03");

        public static Call[] testCalls =
        {
            new Call(testCall1Date, 250, "0888888888"),
            new Call(testCall2Date, 47, "0888123456"),
            new Call(testCall3Date, 50, "0888111111"),
            new Call(testCall4Date, 65, "0888123123"),
            new Call(testCall5Date, 100, "0888999999")
        };

        public static void CreateCallTestHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]);
            }
        }

        public static void DisplayCallTestHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestCallsPrice()
        {
            decimal price = testGSM.CalculateTotalCallsPrice();
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1];
            testGSM.DeleteCalls(longestCall);
        }
    }
}
