using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Products : IProduct
    {
        private string name;
        private string brand;

        public Products(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException(value, "Product name must be between 3 and 10 symbols long!");
                }

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException(value, "Product brand must be between 2 and 10 symbols long!");
                }

                this.brand = value;
            }
        }

        public decimal Price { get; set; }

        public Common.GenderType Gender { get; set; }

        public string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {2}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return result.ToString().TrimEnd();
        }
    }
}
