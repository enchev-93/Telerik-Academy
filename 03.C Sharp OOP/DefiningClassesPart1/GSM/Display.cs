namespace MobilePhone
{
    using System;
    
    public class Display // problem 1, 2, 4, 5
    {
        private double diagonal;
        private int numberOfColors;

        public double Diagonal
        {
            get { return this.diagonal; }
            private set
            {
                if (value == 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Display size should be between 0 and 10!");
                }
                else
                {
                    this.diagonal = value;
                }
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            private set
            {
                if (value < 256 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Number of colorse should be between 256 and int.MaxValue");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        public Display() : this(4.2, 256) { }

        public Display(double size) : this(size, 256) { }

        public Display(double size, int colors)
        {
            this.Diagonal = size;
            this.NumberOfColors = colors;
        }

        public override string ToString()
        {
            return String.Format("Diagonal length: {0}, Number of colors: {1}",
                this.diagonal, this.numberOfColors);
        }

    }
}
