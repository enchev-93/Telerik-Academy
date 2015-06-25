﻿using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class ConvertableChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private const decimal ConvertedHeight = 0.10m;

        public ConvertableChair(string model, Models.MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            :base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }

        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return ConvertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
