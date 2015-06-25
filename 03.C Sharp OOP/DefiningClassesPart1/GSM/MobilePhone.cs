namespace MobilePhone
{
    using System;

    class MobilePhone
    {
        static void Main()
        {
            GSMTest.PrintGSMsInfo(GSMTest.GenerateGSMs(3));
            Console.WriteLine(new string('-', 30));

            GSMCallHistoryTest.CreateCallTestHistory(); // problem 12
            GSMCallHistoryTest.DisplayCallTestHistory();
            Console.WriteLine(new string('-', 30));
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("{0}\n{1}", "Price after the longest call is removed: ", new string('-', 30));
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("{0}\n{1}", "Call history after the longest call is removed: ",new string('-', 30));
            GSMCallHistoryTest.DisplayCallTestHistory();
            Console.WriteLine(new string('-', 30));
            GSMCallHistoryTest.testGSM.ClearCallHistory();
            Console.WriteLine("{0}\n{1}", "Call history list is cleared", new string('-', 30));
            GSMCallHistoryTest.DisplayCallTestHistory();
        }
    }
}
