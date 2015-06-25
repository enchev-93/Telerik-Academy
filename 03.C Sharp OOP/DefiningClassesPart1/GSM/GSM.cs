namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private static GSM iPhone4S; // problem 6
        private string manifacturer; // problem 1
        private string model; // problem 1
        private double price; // problem 1
        private string owner; // problem 1
        private const decimal callPrice = 0.37M; // problem 11
        private Battery battery; // problem 1
        private Display display; // problem 1
        private List<Call> callHistory; // problem 9

        public static GSM IPhone4S // problem 6
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }

        static GSM()
        {
            IPhone4S = new GSM("IPhone", "4S", 1500.99, "Pesho", new Battery("Standard", 100, 10, BatteryTypes.LiIon), new Display(), new List<Call>());
        }

        public string Manifacturer // problem 5
        {
            get { return this.manifacturer; }
            private set
            {
                if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Manifacturer name should be between 0 and 20 symbols!");
                }
                else
                {
                    this.manifacturer = value;
                }
            }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Model name should be between 0 and 20 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (value == 0 || value > 2000)
                {
                    throw new ArgumentOutOfRangeException("Price should be between 0 and 2000");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value.Length == 0 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be between 0 and 50 symbols");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }
        }

        public List<Call> CallHistory // problem 9
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public GSM(string manifacturer, string model) // problem 2
            : this(manifacturer, model, 100.0, "Gosho", new Battery(), new Display(), new List<Call>())
        {
            this.Manifacturer = manifacturer;
            this.Model = model;
        }

        public GSM(string manifacturer, string model, double price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.Manifacturer = manifacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public override string ToString() // problem 4
        {
            return String.Format("\nManifacturer: {0}\n" +
                                 "Model: {1}\n" +
                                 "Price: {2}\n" +
                                 "Owner: {3}\n" +
                                 "Battery: {4}\n" +
                                 "Display: {5}\n",
                                 this.Manifacturer, this.Model, this.Price,
                                 this.Owner, this.Battery.ToString(), this.Display.ToString());
        }

        public List<Call> AddCalls(Call call) // problem 10
        {
            this.CallHistory.Add(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.callHistory);
        }

        public decimal CalculateTotalCallsPrice() // problem 11
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += CallHistory[i].Duration;
            }

            decimal totalPrice = (totalDuration / 60 )* callPrice;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Call history:\n{0}", string.Join(Environment.NewLine, new List<Call>(this.callHistory)));
        }
    }
}
