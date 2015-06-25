﻿using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public virtual string Model
        {
            get { return this.model; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be emptyor null");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Cannot be less than 3 symbols");
                }

                this.model = value;
            }
        }


        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00m");
                }

                this.height = value;
            }
        }

        public virtual string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        protected MaterialType MaterialType { get; set; }
    }
}
