using System;
using System.Threading;

public class TimerTest
{
    /// <summary>
    /// Using delegates write a class Timer that can execute certain method at each t seconds.
    /// </summary>
    public static void Main()
    {
        TimerEvent firstTimerEvent = ExecuteEachThreeSeconds;
        Timer firstTimer = new Timer(3, firstTimerEvent);

        TimerEvent secondTimerEvent = ExecuteEachFiveSeconds;
        Timer secondTimer = new Timer(5, secondTimerEvent);

        Timer thirdTimer = new Timer(delegate { Console.WriteLine("Hi! I show up every second."); });

        Thread firstThread = new Thread(firstTimer.RunTimer);
        firstThread.Start();

        Thread secondThread = new Thread(secondTimer.RunTimer);
        secondThread.Start();

        Thread thirdThreat = new Thread(thirdTimer.RunTimer);
        thirdThreat.Start();
    }

    private static void ExecuteEachThreeSeconds()
    {
        Console.WriteLine("I show up every three seconds.");
    }

    private static void ExecuteEachFiveSeconds()
    {
        Console.WriteLine("I show up every five seconds.");
    }
}
