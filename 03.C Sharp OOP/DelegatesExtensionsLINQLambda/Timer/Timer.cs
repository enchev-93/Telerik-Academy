using System;
using System.Threading;

public delegate void TimerEvent();

public class Timer
{
    private readonly TimerEvent timerEvent;
    private int count;
    private int interval;
    private int ticks;

    public Timer(int count, int interval, TimerEvent timerEvent)
    {
        this.Count = count;
        this.Interval = interval;
        this.Ticks = 0;
        this.timerEvent = timerEvent;
    }

    public Timer(int interval, TimerEvent timerEvent)
        : this(int.MaxValue, interval, timerEvent)
    {
    }

    public Timer(TimerEvent timerEvent)
        : this(int.MaxValue, 1, timerEvent)
    {
    }

    public int Ticks { get; set; }

    public int Interval
    {
        get { return this.interval; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Interval must be bigger than 0.");
            }

            this.interval = value * 1000;
        }
    }

    public int Count
    {
        get { return this.count; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Count must be bigger than 0.");
            }

            this.count = value;
        }
    }

    public void RunTimer()
    {
        while (this.Ticks < this.Count)
        {
            Thread.Sleep(this.Interval);
            this.Ticks++;
            timerEvent();
        }
    }
}
