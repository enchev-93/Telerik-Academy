﻿namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width can not be negative or zero.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height can not be negative or zero.");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
