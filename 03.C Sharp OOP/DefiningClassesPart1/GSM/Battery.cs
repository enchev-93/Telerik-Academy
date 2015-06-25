namespace MobilePhone
{
    using System;

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryTypes type;

        public string Model // problem 1, 2, 3, 4, 5
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0|| value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Model name should be between 0 and 20 symbols!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            private set
            {
                if (value == 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should be between 0 and 500!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            private set
            {
                if (value == 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be between 0 and 50!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryTypes Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public Battery() : this("Standard", 100.0, 10.0, BatteryTypes.LiIon) { }

        public Battery(string model) : this(model, 100.0, 10.0, BatteryTypes.LiIon) { }

        public Battery(string model, double idle, double talk, BatteryTypes type)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.hoursTalk = talk;
            this.Type = type;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
                this.model, this.hoursIdle, this.hoursTalk, this.type);
        }
    }
}
